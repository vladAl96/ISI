using ISIPISI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.ViewModels
{
    public class ReportViewModel
    {
        public ReportViewModel(EventReport rep, Area area)
        {
            this.rep = rep;
            this.area = area;
        }
        public EventReport rep { get; set; }
        public Area area { get; set; }
    }
}
