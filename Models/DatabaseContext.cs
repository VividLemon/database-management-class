using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    class DatabaseContext : DbContext
    {
        public static string dbPath = @"DESKTOP-DUKMCM1\MSSQLSERVER02";
        public static string dbName = "Final";
        private static readonly string connectionString = $"Data Source={dbPath};Initial Catalog={dbName};Integrated Security=True";
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<BusinessInformation> BusinessInformations { get; set; }
        public DbSet<BusinessIssue> BusinessIssues { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<ForumDetail> ForumDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Username).IsUnique();
        }

        // Console is in tools
        // Add-Migration {name}
        // Update-Database
    }
}
