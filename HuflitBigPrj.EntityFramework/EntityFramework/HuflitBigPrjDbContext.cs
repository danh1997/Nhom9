using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using HuflitBigPrj.Authorization.Roles;
using HuflitBigPrj.Authorization.Users;
using HuflitBigPrj.Models;
using HuflitBigPrj.MultiTenancy;

namespace HuflitBigPrj.EntityFramework
{
    public class HuflitBigPrjDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<Inventory> Inventories  { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockDetail> StockDetails { get; set; }
        public DbSet<StockTransfer> StockTranfers { get; set; }
        public DbSet<StockTransDetail> StockTransDetails { get; set; }
        public DbSet<CheckStock> CheckStocks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public HuflitBigPrjDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in HuflitBigPrjDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of HuflitBigPrjDbContext since ABP automatically handles it.
         */
        public HuflitBigPrjDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public HuflitBigPrjDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public HuflitBigPrjDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
