using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Saga> Sagas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Tale> Tales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Sorvildb;Integrated Security=True");
        }
    }
}
