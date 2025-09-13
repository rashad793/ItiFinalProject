using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, Range(0.01, 100000)]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public string ImagePath { get; set; } = @"src\F5ruKkPW4AA2xQr.webp";


        [Required(ErrorMessage = "Category is required")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }


    }
}
