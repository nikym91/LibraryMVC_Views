using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Models.Interfaces
{
    public interface AuthorRepository
    {
        IQueryable<Author> GetAllAuthors();
        Task<Author> DeleteAuthor(int? id);
        Task DeleteAuthorConfirmed(Author author);
        Task AddAuthorAsync(Author author);
        Task<Author> DetailAuthor(int? id);
        Task<Author> EditAuthorById(int? id);
        Task EditAuthor(Author author);
        bool AuthorExistById(int id);
    }
}
