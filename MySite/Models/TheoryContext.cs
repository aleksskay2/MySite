using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class TheoryContext :DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public TheoryContext(DbContextOptions<TheoryContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
