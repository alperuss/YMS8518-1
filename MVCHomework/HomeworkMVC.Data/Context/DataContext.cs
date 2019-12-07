
using HomeworkMVC.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace HomeworkMVC.Data.Context
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }




    }
}
