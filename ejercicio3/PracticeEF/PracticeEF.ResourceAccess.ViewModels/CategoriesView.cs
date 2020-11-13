using System.ComponentModel.DataAnnotations;

namespace PracticeEF.ResourceAccess.ViewModels
{
    public class CategoriesView
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "{0} can not be empty.")]
        [StringLength(15)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

    }
}
