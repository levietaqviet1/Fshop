using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise1
{
    public class Book
    {
        public int ISBN { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }

        public Book()
        {
        }

        public Book(int iSBN, string bookName, string authorName, string publisher)
        {
            this.ISBN = iSBN;
            this.BookName = bookName;
            this.AuthorName = authorName;
            this.Publisher = publisher;
        }

        /// <summary>
        /// In ra thông tin về sách
        /// </summary>
        /// <returns></returns>
        public string GetBookInformation()
        {
            return $"ISBN: {this.ISBN}, BookName: {this.BookName}, AuthorName: {this.AuthorName}, Publisher: {this.Publisher}.";
        }
    }
}
