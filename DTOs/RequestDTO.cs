using System.ComponentModel.DataAnnotations;

namespace TestAPI.DTOs
{
    public class ProductRequestDTO
    {
        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public string ProductStatus { get; set; }

        [Required]
        public float ProductPrice { get; set; }
    }
}
