using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using Recaptcha.Web.Mvc;
using Recaptcha.Web;
using System.Linq;
using Atalon.Models;

namespace Atalon.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IConfiguration _configuration;
        private int? organizationId;
        private int? serviceId;
        private int? materialId;

        public FeedbackController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(FeedbackFormModel model)
        {
            var recaptchaHelper = this.GetRecaptchaVerificationHelper();

            if (String.IsNullOrEmpty(recaptchaHelper.Response))
            {
                ModelState.AddModelError("", "Captcha answer cannot be empty.");
                return View(model);
            }
            
            var recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();

            if (!recaptchaResult.Success)
            {
                foreach (var err in recaptchaResult.ErrorCodes)
                {
                    ModelState.AddModelError("", err);
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var emailMessage = new MimeMessage();

                    emailMessage.From.Add(new MailboxAddress($"Информация о заявке от {model.OrganizationName}",
                                                            _configuration["EmailSettings:SenderEmail"]));
                    emailMessage.To.Add(new MailboxAddress("Recipient Name",
                                                            _configuration["EmailSettings:RecipientEmail"]));
                    emailMessage.Subject = $"Информация о заявке от {model.OrganizationName}";

                    string DateDost = model.DeliveryDate.ToString("dd.MM.yyyy");

                    if (model.AnotherMaterial == null && model.FromLocation == null)
                    {                    
                        emailMessage.Body = new TextPart("plain")
                        {
                            Text = $"Название организации: {model.OrganizationName}\nEmail: {model.Email}\nНазвание услуги: {model.ServiceName}" +
                            $"\nКуда везем: {model.ToLocation}\nДо какого числа доставить: {DateDost}" +
                            $"\nТелефон: {model.PhoneNumber}\nКак обращаться к клиенту: {model.Greeting}"
                        };
                    }
                    else if (model.AnotherMaterial == null)
                    {
                        emailMessage.Body = new TextPart("plain")
                        {
                            Text = $"Название организации: {model.OrganizationName}\nEmail: {model.Email}\nНазвание услуги: {model.ServiceName}" +
                            $"\nОткуда везем: {model.FromLocation}\nКуда везем: {model.ToLocation}\nДо какого числа доставить: {DateDost}" +
                            $"\nТелефон: {model.PhoneNumber}\nКак обращаться к клиенту: {model.Greeting}"
                        };
                    }
                    else if (model.FromLocation == null)
                    {
                        emailMessage.Body = new TextPart("plain")
                        {
                            Text = $"Название организации: {model.OrganizationName}\nEmail: {model.Email}\nНазвание услуги: {model.ServiceName}" +
                            $"\nНазвание другого материала: {model.AnotherMaterial}" +
                            $"\nКуда везем: {model.ToLocation}\nДо какого числа доставить: {DateDost}" +
                            $"\nТелефон: {model.PhoneNumber}\nКак обращаться к клиенту: {model.Greeting}"
                        };
                    }
                    else
                    {
                        emailMessage.Body = new TextPart("plain")
                        {
                            Text = $"Название организации: {model.OrganizationName}\nEmail: {model.Email}\nНазвание услуги: {model.ServiceName}" +
                            $"\nНазвание другого материала: {model.AnotherMaterial}" +
                            $"\nОткуда везем: {model.FromLocation}\nКуда везем: {model.ToLocation}\nДо какого числа доставить: {DateDost}" +
                            $"\nТелефон: {model.PhoneNumber}\nКак обращаться к клиенту: {model.Greeting}"
                        };
                    }

                    using (var client = new SmtpClient())
                    {
                        await client.ConnectAsync(_configuration["EmailSettings:SmtpServer"],
                            int.Parse(_configuration["EmailSettings:SmtpPort"]), SecureSocketOptions.SslOnConnect);
                        await client.AuthenticateAsync(_configuration["EmailSettings:UserName"],
                            _configuration["EmailSettings:Password"]);
                        await client.SendAsync(emailMessage);


                        await client.DisconnectAsync(true);
                    }
                   
                    string organizationName = model.OrganizationName;
                    string emailName = model.Email;
                    string fromLocation = model.FromLocation;
                    string toLocation = model.ToLocation;
                    string TypeService = model.ServiceName;
                    string DopMaterial = model.AnotherMaterial;
                    DateTime dateNow = DateTime.Now;
                    DateTime dateDostavk = model.DeliveryDate;
                    string telnumber = model.PhoneNumber;
                    string NameClient = model.Greeting;

                    using (var context = new Эталон_ТрансContext())
                    {
                        // Проверка наличия строки с таким значением в столбце "Название" таблицы "Организации"
                        bool organizationExists = context.Организацииs
                            .Any(org => org.Название == organizationName);
                        bool telnumberExists = context.Организацииs
                            .Any(org => org.ТелефонДляСвязи == telnumber);
                        bool materialExists = context.Материалs
                            .Any(org => org.Название == DopMaterial);
                        bool serviceExists = context.ТипыУслугs
                            .Any(org => org.Название == TypeService);

                        if (!organizationExists)
                        {
                            // Получение максимального значения id_организации
                            int maxId = context.Организацииs
                                .Select(org => org.IdОрганизации)
                                .DefaultIfEmpty()
                                .Max();

                            // Создание новой записи в таблице "Организации"
                           Организации newOrganization = new Организации
                            {  
                                Название = organizationName,
                               ТелефонДляСвязи = telnumber,
                               IdОрганизации = maxId + 1
                            };

                            // Добавление новой записи в контекст данных
                            context.Организацииs.Add(newOrganization);

                            // Сохранение изменений в базе данных
                            context.SaveChanges();
                        }
                        else if (!telnumberExists)
                        {
                            int maxId = context.Организацииs
                                .Select(org => org.IdОрганизации)
                                .DefaultIfEmpty()
                                .Max();

                            Организации newOrganization = new Организации
                            {
                                Название = organizationName,
                                ТелефонДляСвязи = telnumber,
                                IdОрганизации = maxId + 1
                            };

                            context.Организацииs.Add(newOrganization);

                            context.SaveChanges();
                        }

                        if (!serviceExists)
                        {
                            int maxId = context.ТипыУслугs
                                .Select(org => org.IdТипаУслуги)
                                .DefaultIfEmpty()
                                .Max();

                            ТипыУслуг newService = new ТипыУслуг
                            {
                                Название = TypeService,
                                IdТипаУслуги = maxId + 1
                            };

                            context.ТипыУслугs.Add(newService);

                            context.SaveChanges();
                        }

                        // Если отсутствует в базе данных материал записанный
                        // в форме клиентом, то данный материал заносится в базу данных
                        if (!materialExists)
                        {
                            int maxId = context.Материалs
                                .Select(org => org.IdМатериала)
                                .DefaultIfEmpty()
                                .Max();

                            Материал newMaterial = new Материал
                            {
                                Название = DopMaterial,
                                IdМатериала = maxId + 1
                            };

                            context.Материалs.Add(newMaterial);

                            context.SaveChanges();
                        }

                        if (TypeService == "Перевозка песка" || TypeService == "Перевозка щебня"
                            || TypeService == "Перевозка ЩПС" 
                            || TypeService == "Перевозка другого материала")
                        {

                            Организации OrganizationGoToBase = context.Организацииs
                            .FirstOrDefault(org => org.Название == organizationName);
                            ТипыУслуг ServiceGoToBase = context.ТипыУслугs
                            .FirstOrDefault(org => org.Название == TypeService);

                            if (DopMaterial != null)
                            {
                                Материал MaterialGoToBase = context.Материалs
                                .FirstOrDefault(org => org.Название == DopMaterial);

                                if (MaterialGoToBase != null)
                                {
                                    materialId = MaterialGoToBase.IdМатериала;
                                }
                            }
                            else
                            {
                                if (TypeService == "Перевозка песка")
                                {
                                    Материал MaterialGoToBase = context.Материалs
                                    .FirstOrDefault(org => org.Название == "Песок");
                                    if (MaterialGoToBase != null)
                                    {
                                        materialId = MaterialGoToBase.IdМатериала;
                                    }
                                }
                                else if (TypeService == "Перевозка щебня")
                                {
                                    Материал MaterialGoToBase = context.Материалs
                                    .FirstOrDefault(org => org.Название == "Щебень");
                                    if (MaterialGoToBase != null)
                                    {
                                        materialId = MaterialGoToBase.IdМатериала;
                                    }
                                }
                                else if (TypeService == "Перевозка ЩПС")
                                {
                                    Материал MaterialGoToBase = context.Материалs
                                     .FirstOrDefault(org => org.Название == "ЩПС");
                                    if (MaterialGoToBase != null)
                                    {
                                        materialId = MaterialGoToBase.IdМатериала;
                                    }
                                }
                            }

                            if (OrganizationGoToBase != null)
                            {
                                organizationId = OrganizationGoToBase.IdОрганизации;
                            }
                            if (ServiceGoToBase != null)
                            {
                                serviceId = ServiceGoToBase.IdТипаУслуги;
                            }

                            int maxId = context.ЗаявкиОПеревозкахs
                                .Select(org => org.Id)
                                .DefaultIfEmpty()
                                .Max();

                            ЗаявкиОПеревозках RequestPerevoz = new ЗаявкиОПеревозках
                            {
                                Id = maxId + 1,
                                IdОрганизации = organizationId,
                                IdТипаУслуги = serviceId,
                                IdМатериала = materialId,
                                Email = emailName,
                                АдресОткуда = fromLocation,
                                АдресКуда = toLocation,
                                Фио = NameClient,
                                Дэдлайн = dateDostavk,
                                ДатаВнесенияВБазу = dateNow
                            };
                            context.ЗаявкиОПеревозкахs.Add(RequestPerevoz);

                            context.SaveChanges();
                        }
                        else
                        {
                            Организации OrganizationGoToBase = context.Организацииs
                            .FirstOrDefault(org => org.Название == organizationName);
                            ТипыУслуг ServiceGoToBase = context.ТипыУслугs
                            .FirstOrDefault(org => org.Название == TypeService);

                            if (DopMaterial != null)
                            {
                                Материал MaterialGoToBase = context.Материалs
                                .FirstOrDefault(org => org.Название == DopMaterial);

                                if (MaterialGoToBase != null)
                                {
                                    materialId = MaterialGoToBase.IdМатериала;
                                }
                            }
                            else
                            {
                                if (TypeService == "Поставка песка")
                                {
                                    Материал MaterialGoToBase = context.Материалs
                                    .FirstOrDefault(org => org.Название == "Песок");
                                    if (MaterialGoToBase != null)
                                    {
                                        materialId = MaterialGoToBase.IdМатериала;
                                    }
                                }
                                else if (TypeService == "Поставка щебня")
                                {
                                    Материал MaterialGoToBase = context.Материалs
                                    .FirstOrDefault(org => org.Название == "Щебень");
                                    if (MaterialGoToBase != null)
                                    {
                                        materialId = MaterialGoToBase.IdМатериала;
                                    }
                                }
                                else if (TypeService == "Поставка ЩПС")
                                {
                                    Материал MaterialGoToBase = context.Материалs
                                     .FirstOrDefault(org => org.Название == "ЩПС");
                                    if (MaterialGoToBase != null)
                                    {
                                        materialId = MaterialGoToBase.IdМатериала;
                                    }
                                }
                            }

                            if (OrganizationGoToBase != null)
                            {
                                organizationId = OrganizationGoToBase.IdОрганизации;
                            }
                            if (ServiceGoToBase != null)
                            {
                                serviceId = ServiceGoToBase.IdТипаУслуги;
                            }
                            
                            int maxId = context.ЗаявкиОПоставкахs
                                .Select(org => org.Id)
                                .DefaultIfEmpty()
                                .Max();

                            ЗаявкиОПоставках RequestPostav = new ЗаявкиОПоставках
                            {
                                Id = maxId + 1,
                                IdОрганизации = organizationId,
                                IdТипаУслуги = serviceId,
                                IdМатериала = materialId,
                                Email = emailName,
                                АдресОткуда = fromLocation,
                                АдресКуда = toLocation,
                                Фио = NameClient,
                                Дэдлайн = dateDostavk,
                                ДатаВнесенияВБазу = dateNow
                            };
                            context.ЗаявкиОПоставкахs.Add(RequestPostav);

                            context.SaveChanges();
                        }

                    }
                    
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }
    }
}

