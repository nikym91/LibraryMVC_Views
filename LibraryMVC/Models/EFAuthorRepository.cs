using LibraryMVC.Context;
using LibraryMVC.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Models
{
    public class EFAuthorRepository : AuthorRepository
    {
        private readonly EFLibraryContext context;

        public EFAuthorRepository(EFLibraryContext ctx)
        {
            context = ctx;
        }

        public async Task AddAuthorAsync(Author author)
        {
            context.Add(author);
            await SaveChangesAsync();
        }
        private async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public bool AuthorExistById(int id)
        {
            return context.Authors.Any(e => e.Id == id);
        }

        public Task<Author> DeleteAuthor(int? id)
        {
            return context.Authors
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task DeleteAuthorConfirmed(Author author)
        {
            context.Authors.Remove(author);
            await SaveChangesAsync();
        }

        public Task<Author> DetailAuthor(int? id)
        {
            return context.Authors
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task EditAuthor(Author author)
        {
            context.Update(author);
            await SaveChangesAsync();
        }

        public Task<Author> EditAuthorById(int? id)
        {
            return context.Authors.FindAsync(id);
        }

        public IQueryable<Author> GetAllAuthors()
        {
            return context.Authors;
        }
    }
}
