using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public interface IReportsRepository
    {
        IEnumerable<EventReport> Reports { get; }

        EventReport getEventReportById(int reportId);
        IEnumerable<EventReport> getReportsByAreaId(int areaId);
        void Add(EventReport report);
    }
}
