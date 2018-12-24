using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public double PH { get; set; }
        public double PollutionPercentage { get; set; }
        public double NocSubsQTTY { get; set; }
    }
}
