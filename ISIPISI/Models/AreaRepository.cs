using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public class AreaRepository : IAreaRepository
    {
        public readonly AppDbContext _appDbContext;

        public AreaRepository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IEnumerable<Area> Areas
        {
            get
            {
                return _appDbContext.Areas;
            }
        }

        public void Add(Area area)
        {
            _appDbContext.Areas.Add(area);
            _appDbContext.SaveChanges();
        }

        public Area getAreaById(int areaId)
        {
            return _appDbContext.Areas.First(a => a.AreaId == areaId);
        }

        public Area getAreaByName(string areaName)
        {
            return _appDbContext.Areas.First(a => a.AreaName.Equals(areaName));
        }
    }
}
