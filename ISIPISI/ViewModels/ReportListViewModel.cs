using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.ViewModels
{
    public class ReportListViewModel
    {
        public ReportListViewModel()
        {
            ReportsVM = new List<ReportViewModel>();
        }
        public List<ReportViewModel> ReportsVM { get; set; }
    }
}
