using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Atalon.Models
{
    public partial class Материал
    {
        [Key]
        public int IdМатериала { get; set; }
        public string Название { get; set; }
        public string ЦенаЗаТонну { get; set; }
        public string ЦенаЗаКуб { get; set; }
    }
}
