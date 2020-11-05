using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeEF.Logic.Implementations
{
    public class RegionLogic : IRegionLogic
    {
        private readonly NorthwindContext context;

        public RegionLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Region> GetRegions()
        {
            try
            {
                return context.Region.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Region GetRegion(int id)
        {
            try
            {
                return context.Region.FirstOrDefault(r => r.RegionID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void AddRegion(Region region)
        {
            try
            {
                context.Region.Add(region);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateRegion(Region region)
        {
            try
            {
                context.Entry(region).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteRegion(Region region)
        {
            try
            {
                context.Region.Remove(region);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
