using System;
using System.Collections.Generic;

#nullable disable

namespace Atalon.Models
{
    public partial class Material
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string CostOfVolume { get; set; }
        public string CostOfMass { get; set; }
    }
}
