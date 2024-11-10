using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Margoi_Cornel_Lab2.Models;

namespace Margoi_Cornel_Lab2.Data
{
    public class Margoi_Cornel_Lab2Context : DbContext
    {
        public Margoi_Cornel_Lab2Context (DbContextOptions<Margoi_Cornel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Margoi_Cornel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Margoi_Cornel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Margoi_Cornel_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Margoi_Cornel_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
