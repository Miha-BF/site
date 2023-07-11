using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class ОплатаВодителям
    {
        public int? IdРейса { get; set; }
        public int? IdВодителя { get; set; }
        public string Оплата { get; set; }

        public virtual Водители IdВодителяNavigation { get; set; }
        public virtual ВыполненияРейсов IdРейсаNavigation { get; set; }
    }
}
