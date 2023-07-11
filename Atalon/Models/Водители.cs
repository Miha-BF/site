using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class Водители
    {
        public Водители()
        {
            ВыполненияРейсовs = new HashSet<ВыполненияРейсов>();
            РасписаниеВодителейs = new HashSet<РасписаниеВодителей>();
        }

        public int IdВодителя { get; set; }
        public string Фамилия { get; set; }
        public string Статус { get; set; }

        public virtual ICollection<ВыполненияРейсов> ВыполненияРейсовs { get; set; }
        public virtual ICollection<РасписаниеВодителей> РасписаниеВодителейs { get; set; }
    }
}
