

namespace FA.BookStore.Core.Models
{

    public class Publisher
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
