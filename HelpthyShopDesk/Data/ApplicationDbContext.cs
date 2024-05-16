using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpthyShopDesk.Models;
using Microsoft.EntityFrameworkCore;
namespace HelpthyShopDesk.Data
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<AdminCode> AdminCodes { get; set; }
        public DbSet<Category> Categores { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-EGE9I3B\\SQLEXPRESS;Database=HealphyShopDesckTop;Trusted_Connection=True;TrustServerCertificate=True", x =>
            {
                x.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            });
        }

    }
}
