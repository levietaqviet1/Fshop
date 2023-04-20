using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWEB.Practice.T01.Core.Model
{
    public class Flower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [RegularExpression("^(Red|Pink|Blue|Lavender|Orange|Purple)$", ErrorMessage = "Invalid color value")]
        public string? Color { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime StoreDate { get; set; }
        public int StoreInventory { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
