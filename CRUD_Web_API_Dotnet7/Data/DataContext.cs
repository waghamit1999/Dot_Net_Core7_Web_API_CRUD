global using Microsoft.EntityFrameworkCore;

namespace CRUD_Web_API_Dotnet7.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string sqlConnectionString = "Server=.\\SQLEXPRESS;Database=Sample DB 001;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(sqlConnectionString);
        }

        public DbSet<Employees> Employees { get; set; }
    }
}
