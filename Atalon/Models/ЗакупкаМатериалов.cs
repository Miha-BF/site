using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class ЗакупкаМатериалов
    {
        public int? IdМатериала { get; set; }
        public int? IdПоставщика { get; set; }
        public string Количество { get; set; }
        public string ЕдиницыИзмерения { get; set; }
        public string Сумма { get; set; }

        public virtual Материал IdМатериалаNavigation { get; set; }
        public virtual Поставщики IdПоставщикаNavigation { get; set; }
    }
}
