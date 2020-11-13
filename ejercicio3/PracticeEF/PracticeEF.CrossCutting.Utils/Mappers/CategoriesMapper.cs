using PracticeEF.ResourceAccess.Entities;
using PracticeEF.ResourceAccess.ViewModels;

namespace PracticeEF.CrossCutting.Utils.Mappers
{
    public static class CategoriesMapper
    {
       
        public static Categories ToEntity(this CategoriesView categoriesView)
        {
            Categories categories = new Categories()
                                    {
                                        CategoryID = categoriesView.CategoryID,
                                        CategoryName = categoriesView.CategoryName,
                                        Description = categoriesView.Description,
                                        Picture = categoriesView.Picture
                                    };

            return categories;
        }

        public static CategoriesView ToViewModel(this Categories categories)
        {
            CategoriesView categoriesView = new CategoriesView()
                                            {
                                                CategoryID = categories.CategoryID,
                                                CategoryName = categories.CategoryName,
                                                Description = categories.Description,
                                                Picture = categories.Picture
                                            };

            return categoriesView;
        }
    }
}
