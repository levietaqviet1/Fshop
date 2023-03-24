﻿namespace FA.BookStore.Core.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
