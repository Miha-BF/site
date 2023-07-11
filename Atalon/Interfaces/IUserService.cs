/*using Atalon.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace Atalon.Interfaces
{

    public interface IUserService
    {
        Task<Регистрация> GetUserByLoginAndPassword(string login, string password);
        Task<bool> CreateUser(string login, string password);
    }

    public class UserService : IUserService
    {
        private readonly Эталон_ТрансContext _context;

        public UserService(Эталон_ТрансContext context)
        {
            _context = context;
        }

        public async Task<Регистрация> GetUserByLoginAndPassword(string login, string password)
        {
            return await _context.Регистрацияs.FirstOrDefaultAsync(x => x.Логин == login && x.Пароль == password);
        }

        public async Task<bool> CreateUser(string login, string password)
        {
            // Проверка наличия пользователя в базе данных
            var existingUser = await _context.Регистрацияs.FirstOrDefaultAsync(x => x.Логин == login);
            if (existingUser != null)
            {
                // Пользователь уже существует
                return false;
            }

            // Создание нового пользователя
            var newUser = new Регистрация
            {
                Логин = login,
                Пароль = password
            };
            _context.Регистрацияs.Add(newUser);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
*/