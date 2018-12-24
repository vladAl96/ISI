using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Models
{
    public interface IAreaRepository
    {
        IEnumerable<Area> Areas { get; }

        Area getAreaById(int areaId);
        Area getAreaByName(string areaName);
        void Add(Area area);
    }
}
