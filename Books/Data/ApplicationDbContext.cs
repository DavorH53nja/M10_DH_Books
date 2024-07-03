using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Books.Models;

namespace Books.Data
{
    public class ApplicationUser : IdentityUser
    {
        
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book>? Books { get; set; }
        public DbSet<Author>? Author { get; set; }
        public DbSet<Publisher>? Publisher { get; set; }
    }
}
