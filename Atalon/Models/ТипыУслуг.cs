using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Atalon.Models
{
    public partial class ТипыУслуг
    {
        public ТипыУслуг()
        {
            ДоговорНаМногоразовуюУслугуs = new HashSet<ДоговорНаМногоразовуюУслугу>();
            ДоговорНаОдиночнуюУслугуs = new HashSet<ДоговорНаОдиночнуюУслугу>();
        }
        [Key]
        public int IdТипаУслуги { get; set; }
        public string Название { get; set; }

        public virtual ICollection<ДоговорНаМногоразовуюУслугу> ДоговорНаМногоразовуюУслугуs { get; set; }
        public virtual ICollection<ДоговорНаОдиночнуюУслугу> ДоговорНаОдиночнуюУслугуs { get; set; }
    }
}
