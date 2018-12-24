using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReportsRepository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IEnumerable<EventReport> Reports
        {
            get
            {
                return _appDbContext.Reports;
            }
        }

        public void Add(EventReport report)
        {
            _appDbContext.Reports.Add(report);
            _appDbContext.SaveChanges();
        }

        public EventReport getEventReportById(int reportId)
        {
            return _appDbContext.Reports.FirstOrDefault(e => e.EventReportId == reportId);
        }

        public IEnumerable<EventReport> getReportsByAreaId(int areaId)
        {
            return _appDbContext.Reports.Where(e => e.areaId == areaId);
        }
    }
}
