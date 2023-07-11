using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class ВыполнениеРасписания
    {
        public int? IdРасписания { get; set; }
        public DateTime? Дата { get; set; }
        public string ОписаниеБылНеБыл { get; set; }
        public string КоличествоРейсов { get; set; }
        public TimeSpan? ФактическоеВремяНачалаРаботы { get; set; }
        public TimeSpan? ФактическоеВремяОкончанияРаботы { get; set; }

        public virtual РасписаниеВодителей IdРасписанияNavigation { get; set; }
    }
}
