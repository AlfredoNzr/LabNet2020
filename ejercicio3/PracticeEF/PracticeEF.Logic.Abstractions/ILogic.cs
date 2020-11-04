using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;


namespace PracticeEF.Logic.Abstractions
{
    public interface ILogic<TEntity>
    {
        List<TEntity> GetAll();

        TEntity GetOne(int id);

        void Insert(TEntity entity);

        void Modify(TEntity entity);

        void Delete(TEntity entity);
        
    }
}
