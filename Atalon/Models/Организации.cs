using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Atalon.Models
{
    public partial class Организации
    {
        public Организации()
        {
            ВыполненияРейсовs = new HashSet<ВыполненияРейсов>();
            ДоговорНаМногоразовуюУслугуs = new HashSet<ДоговорНаМногоразовуюУслугу>();
            ДоговорНаОдиночнуюУслугуs = new HashSet<ДоговорНаОдиночнуюУслугу>();
        }

        [Key]
        public int IdОрганизации { get; set; }
        public string Название { get; set; }
        public string ТелефонДляСвязи { get; set; }
        public string Инн { get; set; }

        public virtual ICollection<ВыполненияРейсов> ВыполненияРейсовs { get; set; }
        public virtual ICollection<ДоговорНаМногоразовуюУслугу> ДоговорНаМногоразовуюУслугуs { get; set; }
        public virtual ICollection<ДоговорНаОдиночнуюУслугу> ДоговорНаОдиночнуюУслугуs { get; set; }
    }
}
