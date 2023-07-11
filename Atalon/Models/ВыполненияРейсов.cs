using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class ВыполненияРейсов
    {
        public int IdРейса { get; set; }
        public int? НомерДоговора { get; set; }
        public int? IdОрганизации { get; set; }
        public int? IdВодителя { get; set; }
        public int? IdМашины { get; set; }
        public DateTime? ФактическаяДатаНачалаРаботы { get; set; }
        public DateTime? ФактическаяДатаОкончанияРаботы { get; set; }

        public virtual Водители IdВодителяNavigation { get; set; }
        public virtual Машины IdМашиныNavigation { get; set; }
        public virtual Организации IdОрганизацииNavigation { get; set; }
        public virtual ДоговорНаОдиночнуюУслугу НомерДоговораNavigation { get; set; }
    }
}
