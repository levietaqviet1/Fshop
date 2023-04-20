using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWEB.Practice.T01.Core.Model
{
    public class Category
    {
        public Category()
        {
            Flowers = new List<Flower>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [DefaultValue(1)]
        public int Order { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        public virtual IList<Flower> Flowers { get; }

    }
}
