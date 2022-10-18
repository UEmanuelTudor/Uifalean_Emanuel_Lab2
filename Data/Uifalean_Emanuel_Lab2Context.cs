using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uifalean_Emanuel_Lab2.Models;

namespace Uifalean_Emanuel_Lab2.Data
{
    public class Uifalean_Emanuel_Lab2Context : DbContext
    {
        public Uifalean_Emanuel_Lab2Context (DbContextOptions<Uifalean_Emanuel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Uifalean_Emanuel_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Uifalean_Emanuel_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
