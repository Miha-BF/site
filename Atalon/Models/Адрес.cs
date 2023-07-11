using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class Адрес
    {
        public Адрес()
        {
            ДоговорНаМногоразовуюУслугуIdАдресаКудаNavigations = new HashSet<ДоговорНаМногоразовуюУслугу>();
            ДоговорНаМногоразовуюУслугуIdАдресаОткудаNavigations = new HashSet<ДоговорНаМногоразовуюУслугу>();
            ДоговорНаОдиночнуюУслугуIdАдресаКудаNavigations = new HashSet<ДоговорНаОдиночнуюУслугу>();
            ДоговорНаОдиночнуюУслугуIdАдресаОткудаNavigations = new HashSet<ДоговорНаОдиночнуюУслугу>();
        }

        public int IdАдреса { get; set; }
        public string Область { get; set; }
        public string Город { get; set; }
        public string Район { get; set; }
        public string Улица { get; set; }
        public string Дом { get; set; }
        public string Описание { get; set; }

        public virtual ICollection<ДоговорНаМногоразовуюУслугу> ДоговорНаМногоразовуюУслугуIdАдресаКудаNavigations { get; set; }
        public virtual ICollection<ДоговорНаМногоразовуюУслугу> ДоговорНаМногоразовуюУслугуIdАдресаОткудаNavigations { get; set; }
        public virtual ICollection<ДоговорНаОдиночнуюУслугу> ДоговорНаОдиночнуюУслугуIdАдресаКудаNavigations { get; set; }
        public virtual ICollection<ДоговорНаОдиночнуюУслугу> ДоговорНаОдиночнуюУслугуIdАдресаОткудаNavigations { get; set; }
    }
}
