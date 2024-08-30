using Microsoft.EntityFrameworkCore;
using ShipIt.Models.DataModels;

namespace ShipIt.Data
{
    public class ShipItDbContext : DbContext
    {
        public DbSet<CompanyDataModel> Company { get; set; }
        public DbSet<EmployeeDataModel> Employees { get; set; }
        public DbSet<ProductDataModel> Products { get; set; }
        public DbSet<StockDataModel> StockDataModels { get; set; }
    }
}