using Microsoft.EntityFrameworkCore;

namespace FirstApi
{
    public class ApiDBConfig : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // how do i use config
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=stock_data;");
        }
    }
}