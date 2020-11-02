using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;

namespace PracticeEF.Logic.Abstractions
{
    public interface ISuppliersLogic
    {
        List<Suppliers> GetSuppliers();

        Suppliers GetSuppliers(int id);

        void AddSuppliers(Suppliers suppliers);

        void UpdateSuppliers(Suppliers suppliers);

        void DeleteSuppliers(Suppliers suppliers);
    }
}
