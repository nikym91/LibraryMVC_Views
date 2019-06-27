using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Models.Interfaces
{
    public interface AuthorRepository
    {
        IEnumerable<Author> GetAllAuthors();
        void DeleteAuthor();
        void AddAuthor();
    }
}
