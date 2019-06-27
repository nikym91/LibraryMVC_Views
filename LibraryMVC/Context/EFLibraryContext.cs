using LibraryMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Context
{
    public class EFLibraryContext : DbContext
    {
        public EFLibraryContext(DbContextOptions<EFLibraryContext> options)
                    : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }

    public class ApplicationDbContextFactory
            : IDesignTimeDbContextFactory<EFLibraryContext>
    {

        public EFLibraryContext CreateDbContext(string[] args) =>
            Program.BuildWebHost(args).Services
                .GetRequiredService<EFLibraryContext>();
    }
}
