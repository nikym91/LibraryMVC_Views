using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumPag { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public Book() { }
        public Book(int id, string title, int numpag, int authorId)
        {
            Id = id;
            Title = title;
            NumPag = numpag;
            AuthorId = authorId;
        }
    }
}
