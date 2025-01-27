using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStore.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [ValidateNever]
        [DisplayName("Image URL")]
        public string? ImageUrl { get; set; }

        [Required]
        [DisplayName("Price")]
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Quantity")]
        public string Quantity { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }


        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
    }
}