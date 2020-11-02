using PracticeEF.ResourceAccess.Entities;
using System.Collections.Generic;

namespace PracticeEF.Logic.Abstractions
{
    public interface ICategoriesLogic
    {
        List<Categories> GetCategories();


        Categories GetCategories(int id);


        void AddCategories(Categories categories);


        void UpdateCategories(Categories pCategories);

        void DeleteCategories(Categories categories);
        

    }
}
