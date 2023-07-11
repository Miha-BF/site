using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Atalon.Models
{
    public partial class ЗаявкиОПеревозках
    {
        [Key]
        public int Id { get; set; } // обязательно для таблиц связи
        public int? IdОрганизации { get; set; }
        public int? НомерДоговора { get; set; }
        public int? IdТипаУслуги { get; set; }
        public int? IdМатериала { get; set; }
        public string Email { get; set; }
        public string АдресОткуда { get; set; }
        public string АдресКуда { get; set; }
        public string Фио { get; set; }
        public DateTime? Дэдлайн { get; set; }
        public DateTime? ДатаВнесенияВБазу { get; set; }
        public DateTime? ДатаОбработкиЗаявки { get; set; }

        public virtual Организации IdОрганизацииNavigation { get; set; }
        public virtual ТипыУслуг IdТипаУслугиNavigation { get; set; }
        public virtual ДоговорНаОдиночнуюУслугу НомерДоговораNavigation { get; set; }
    }
}
