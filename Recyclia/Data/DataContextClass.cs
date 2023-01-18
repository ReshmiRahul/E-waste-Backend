using Microsoft.EntityFrameworkCore;
using Recyclia.Model;

namespace Recyclia.Data
{
    public class DataContextClass : DbContext
    {
        public DataContextClass(DbContextOptions<DataContextClass> options) : base(options)
        {



        }
        public DbSet<Agency> tbl_Agency { get; set; }
        public DbSet<Agency_Login> tbl_Login_Agency { get; set; }
        public DbSet<Customer> tbl_Customer { get; set; }
        public DbSet<Employee> tbl_Employee { get; set; }
        public DbSet<ewaste> tbl_Ewaste{ get; set; }
        public DbSet<Complaints> tbl_Complaints { get; set; }
        public DbSet<Product> tbl_Product { get; set; }

        public DbSet<foodwaste> tbl_foodwaste { get; set; }
    }
}
