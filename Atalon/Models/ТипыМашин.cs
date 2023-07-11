using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class ТипыМашин
    {
        public ТипыМашин()
        {
            Машиныs = new HashSet<Машины>();
        }

        public string IdТипа { get; set; }
        public string Название { get; set; }
        public string ВместимостьВТоннах { get; set; }
        public string ВместимостьВКубах { get; set; }

        public virtual ICollection<Машины> Машиныs { get; set; }
    }
}
