using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;

namespace PracticeEF.Logic.Abstractions
{
    public interface IProductsLogic
    {
        List<Products> GetProducts();

        Products GetProduct(int id);

        void AddProducts(Products products);

        void UpdateProducts(Products products);

        void DeleteProducts(Products products);
    }
}
