using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;

namespace PracticeEF.Logic.Abstractions
{
    public interface IShippersLogic
    {
        List<Shippers> GetShippers();

        Shippers GetShippers(int id);

        void AddShippers(Shippers shippers);

        void UpdateShippers(Shippers shippers);

        void DeleteShippers(Shippers shippers);
    }
}
