using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class ДоговорНаОдиночнуюУслугу
    {
        public ДоговорНаОдиночнуюУслугу()
        {
            ВыполненияРейсовs = new HashSet<ВыполненияРейсов>();
        }

        public int НомерДоговора { get; set; }
        public int? IdОрганизации { get; set; }
        public int? IdТипаУслуги { get; set; }
        public int? IdАдресаОткуда { get; set; }
        public int? IdАдресаКуда { get; set; }
        public DateTime? ДатаНачалаРаботы { get; set; }
        public DateTime? ДатаОкончанияРаботы { get; set; }
        public string Сумма { get; set; }
        public string ТипОплаты { get; set; }
        public DateTime? ДатаВнесенияВБдИзТаблицыЗаявок { get; set; }
        public string ПризнакДопСоглашения { get; set; }
        public string НомерДопСоглашения { get; set; }

        public virtual Адрес IdАдресаКудаNavigation { get; set; }
        public virtual Адрес IdАдресаОткудаNavigation { get; set; }
        public virtual Организации IdОрганизацииNavigation { get; set; }
        public virtual ТипыУслуг IdТипаУслугиNavigation { get; set; }
        public virtual ICollection<ВыполненияРейсов> ВыполненияРейсовs { get; set; }
    }
}
