using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroceryStore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}