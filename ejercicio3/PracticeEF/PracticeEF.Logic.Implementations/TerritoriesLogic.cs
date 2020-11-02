using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.Logic.Implementations
{
    public class TerritoriesLogic
    {
        private readonly NorthwindContext context;

        public TerritoriesLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Territories> GetTerritories()
        {
            try
            {
                return context.Territories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Territories GetTerritories(int id)
        {
            try
            {
                return context.Territories.FirstOrDefault(r => r.TerritoryID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddTerritories(Territories territories)
        {
            try
            {
                context.Territories.Add(territories);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateTerritories(Territories territories)
        {
            try
            {
                context.Entry(territories).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
