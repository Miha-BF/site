using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class КлиентОрганизация
    {
        public string IdКлиента { get; set; }
        public int? IdОрганизации { get; set; }
        public string Фио { get; set; }
        public string Email { get; set; }

        public virtual Регистрация IdКлиентаNavigation { get; set; }
        public virtual Организации IdОрганизацииNavigation { get; set; }
    }
}
