using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class РасписаниеВодителей
    {
        public int IdРасписания { get; set; }
        public int? IdВодителя { get; set; }
        public string ДеньНедели { get; set; }
        public TimeSpan? ВремяНачала { get; set; }
        public TimeSpan? ВремяОкончания { get; set; }

        public virtual Водители IdВодителяNavigation { get; set; }
    }
}
