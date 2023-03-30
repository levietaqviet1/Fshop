using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    public class Book
    {
        //[Key]
        public int BookId { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
