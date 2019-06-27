using LibraryMVC.Context;
using LibraryMVC.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Models
{
    public class EFBookRepository : BookRepository
    {
        private readonly EFLibraryContext _context;
        public EFBookRepository(EFLibraryContext c)
        {
            _context = c;
        }
        public async Task AddBookAsync(Book book)
        {
            _context.Add(book);
            await SaveChangesAsync();
        }
        private async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public Task<Book> DeleteBook(int? id)
        {
            return _context.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public Task<Book> DetailBook(int? id)
        {
            return _context.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public IQueryable<Book> GetAllBooks()
        {
            return _context.Books.Include(b => b.Author);
        }

        public IQueryable<Author> GetAuthors()
        {
            return _context.Authors;
        }

        public Task<Book> EditBookById(int? id)
        {
            return _context.Books.FindAsync(id);
        }

        public async Task EditBook(Book book)
        {
             _context.Update(book);
            await SaveChangesAsync();

        }

        public async Task DeleteBookConfirmed(Book book)
        {
            _context.Books.Remove(book);
            await SaveChangesAsync();
        }

        public bool BookExistById(int id)
        {
           return _context.Books.Any(e => e.Id == id);
        }
    }
}
