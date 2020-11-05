using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeEF.Logic.Implementations
{
    public class RegionLogic : BaseLogic, ILogic<Region>
    {

        public List<Region> GetAll()
        {
            try
            {
                return context.Region.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Region GetOne(int id)
        {
            try
            {
                return context.Region.FirstOrDefault(r => r.RegionID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Insert(Region region)
        {
            try
            {
                context.Region.Add(region);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Region region)
        {
            try
            {
                context.Entry(region).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Region region)
        {
            try
            {
                context.Region.Remove(region);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
