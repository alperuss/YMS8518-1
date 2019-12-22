using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 1000; i++)
            {
                modelBuilder.Entity<Models.User>().HasData(new Models.User()
                {
                    Id = i,
                    Name = "Adı -" + i,
                    Surname = "Soyadı - " + i,
                    Age = 18 + i
                });
            }
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Models.User> Users { get; set; }
    }
   
}
