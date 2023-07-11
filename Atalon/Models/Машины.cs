using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class Машины
    {
        public Машины()
        {
            ВыполненияРейсовs = new HashSet<ВыполненияРейсов>();
        }

        public int IdМашины { get; set; }
        public string НомерМашины { get; set; }
        public string IdТипа { get; set; }

        public virtual ТипыМашин IdТипаNavigation { get; set; }
        public virtual ICollection<ВыполненияРейсов> ВыполненияРейсовs { get; set; }
    }
}
