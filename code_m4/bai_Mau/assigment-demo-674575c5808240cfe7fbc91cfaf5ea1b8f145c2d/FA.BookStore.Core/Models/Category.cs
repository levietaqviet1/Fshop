using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    //[Table("Category")]
    public class Category
    {
        //[Key]
        public int CategoryId { get; set; }

        //[Required]
        //[StringLength(100)]
        public string CategoryName { get; set; }

        //[Required]
        public string Description { get; set; }

        public string UrlSlug { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
