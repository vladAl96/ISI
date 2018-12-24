using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public class ReportFormModel
    {
        [Display(Name = "Area")]
        [Required(ErrorMessage = "Please specify the area")]
        public string areaName{ get; set; }

        public string reporterUsername { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please describe the event")]
        public string reportDescription { get; set; }

        [Display(Name = "PH")]
        public double PHChange { get; set; } = 0;
        [Display(Name = "Procent de poluare")]
        public double PollutionPercentageChange { get; set; } = 0;
        [Display(Name ="Cantitate de subtsante nocive")]
        public double NocSubsQTYChange { get; set; } = 0;
        public IEnumerable<Area> _areas;

        public ReportFormModel(IEnumerable<Area> areas)
        {
            _areas = areas;
        }

        public ReportFormModel()
        {

        }
    }
}
