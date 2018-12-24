using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISIPISI.Models;
using ISIPISI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ISIPISI.Controllers
{
    public class ReportController : Controller
    {
        private IAreaRepository _areaRepo;
        private IReportsRepository _reportRepo;

        public ReportController(IAreaRepository areaRepo,
            IReportsRepository reportRepo)
        {
            _reportRepo = reportRepo;
            _areaRepo = areaRepo;
        }
       [HttpGet]
       public IActionResult Add()
       {
            return View(new ReportFormModel(_areaRepo.Areas));
       }

       [HttpPost]
       public IActionResult Add(ReportFormModel rep)
       {
            if(ModelState.IsValid)
            {
                var report = new EventReport
                {
                    reportDescription = rep.reportDescription,
                    Approved = false,
                    areaId = _areaRepo.getAreaByName(rep.areaName).AreaId,
                    NocSubsQTYChange = rep.NocSubsQTYChange,
                    PHChange = rep.PHChange,
                    PollutionPercentageChange = rep.PollutionPercentageChange,
                    reporterUsername = User.Identity.Name,
                    ReportDate = DateTime.Now.ToString("MM/dd/yyyy")
                };
                _reportRepo.Add(report);
                return View("ReportAdded");
            }
            return View(new EventReport());
       }

        public IActionResult List()
        {
            var rlvm = new ReportListViewModel();
            foreach(var report in _reportRepo.Reports)
            {
                rlvm.ReportsVM.Add(new ReportViewModel(report, _areaRepo.getAreaById(report.areaId)));
            }
            return View(rlvm);
        }

        [Route("/Report/Specific/{reportId}")]
        public IActionResult Specific(int reportId)
        {
            var report = _reportRepo.getEventReportById(reportId);
            var rvm = new ReportViewModel(report, _areaRepo.getAreaById(report.areaId));
            return View(rvm);
        }
    }
}
