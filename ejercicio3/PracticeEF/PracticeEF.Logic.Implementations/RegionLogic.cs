using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeEF.Logic.Implementations
{
<<<<<<< HEAD
    public class RegionLogic : IRegionLogic
    {
        private readonly NorthwindContext context;

        public RegionLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Region> GetRegions()
=======
    public class RegionLogic : BaseLogic, ILogic<Region>
    {

        public List<Region> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Region.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Region GetRegion(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Region GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Region.FirstOrDefault(r => r.RegionID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }
        
        public void AddRegion(Region region)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Insert(Region region)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Region.Add(region);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateRegion(Region region)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Region region)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(region).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteRegion(Region region)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Region region)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Region.Remove(region);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
=======
            catch (Exception ex)
            {
                throw ex;
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
            }
        }
    }
}
