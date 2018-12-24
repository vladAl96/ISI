using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public class EventReport
    {
        public int EventReportId { get; set; }
        public int areaId { get; set; }
        public string reporterUsername { get; set; }
        public string ReportDate { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");

        [Required(ErrorMessage = "Please describe the event")]
        public string reportDescription { get; set; }

        public double PHChange { get; set; } = 0;
        public double PollutionPercentageChange { get; set; } = 0;
        public double NocSubsQTYChange { get; set; } = 0;
        public bool Approved { get; set; } = false;
    }
}
