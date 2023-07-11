using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class Заказ
    {
        public int? НомерДоговора { get; set; }
        public int? IdМатериала { get; set; }
        public string КоличествоТонн { get; set; }
        public string КоличествоКубов { get; set; }

        public virtual ДоговорНаОдиночнуюУслугу IdМатериала1 { get; set; }
        public virtual Материал IdМатериалаNavigation { get; set; }
        public virtual ДоговорНаМногоразовуюУслугу НомерДоговораNavigation { get; set; }
    }
}
