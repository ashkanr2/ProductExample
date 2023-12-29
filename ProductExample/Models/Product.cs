using System.ComponentModel.DataAnnotations;

namespace ProductExample.Models
{
    // Models/Product.cs


    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "نام محصول الزامی است.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "قیمت محصول الزامی است.")]
        public decimal Price { get; set; }
    }

}
