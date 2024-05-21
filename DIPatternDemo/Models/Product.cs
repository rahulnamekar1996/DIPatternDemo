using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DIPatternDemo.Models
{
    [Table("pro")]

    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Company { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }

}
