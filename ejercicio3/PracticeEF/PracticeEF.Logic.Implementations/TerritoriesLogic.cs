using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.Logic.Implementations
{
    public class TerritoriesLogic: BaseLogic, ILogic<Territories>
    {

        public List<Territories> GetAll()
        {
            try
            {
                return context.Territories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Territories GetOne(int id)
        {
            try
            {
                return context.Territories.FirstOrDefault(r => r.TerritoryID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Territories territories)
        {
            try
            {
                context.Territories.Add(territories);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Territories territories)
        {
            try
            {
                context.Entry(territories).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Territories entity)
        {
            throw new NotImplementedException();
        }
    }
}
