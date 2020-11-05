<<<<<<< HEAD
﻿using PracticeEF.ResourceAccess.DataBase;
=======
﻿using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.Logic.Implementations
{
<<<<<<< HEAD
    public class TerritoriesLogic
    {
        private readonly NorthwindContext context;

        public TerritoriesLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Territories> GetTerritories()
=======
    public class TerritoriesLogic: BaseLogic, ILogic<Territories>
    {

        public List<Territories> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Territories.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Territories GetTerritories(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Territories GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Territories.FirstOrDefault(r => r.TerritoryID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void AddTerritories(Territories territories)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Territories territories)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Territories.Add(territories);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateTerritories(Territories territories)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Territories territories)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(territories).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                throw;
            }
        }
=======
                throw ex;
            }
        }

        public void Delete(Territories entity)
        {
            throw new NotImplementedException();
        }
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
    }
}
