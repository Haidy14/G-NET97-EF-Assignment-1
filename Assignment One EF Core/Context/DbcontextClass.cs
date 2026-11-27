using Assignment_One_EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One_EF_Core.Context
{
    internal class DbcontextClass : DbContext
    {
        public DbcontextClass() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Dbcontext;Trusted_Connection=true;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("DataSource=.;IntialCatlog=CompanyDb;Integrated_Security=true");
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }


    }
}
