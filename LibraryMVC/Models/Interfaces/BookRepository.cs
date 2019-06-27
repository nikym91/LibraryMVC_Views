using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Models.Interfaces
{
    public interface BookRepository
    {
        IQueryable<Book> GetAllBooks();
        Task<Book> DeleteBook(int? id);
        Task DeleteBookConfirmed(Book book);
        Task AddBookAsync(Book book);
        Task<Book> DetailBook(int? id);
        IQueryable<Author> GetAuthors();
        Task<Book> EditBookById(int? id);
        Task EditBook(Book book);
        bool BookExistById(int id);
    }
}
