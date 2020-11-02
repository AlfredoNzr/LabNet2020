using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;

namespace PracticeEF.Logic.Abstractions
{
    public interface IRegionLogic
    {
        List<Region> GetRegions();


        Region GetRegion(int id);

        void AddRegion(Region region);

        void UpdateRegion(Region region);

        void DeleteRegion(Region region);
    }
}
