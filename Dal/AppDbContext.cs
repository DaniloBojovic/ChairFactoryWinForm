using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Model;

namespace Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base()
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasOptional(i => i.Part).WithMany(i => i.Parts).HasForeignKey(i => i.PartId).WillCascadeOnDelete(false);
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OperationPlan> OperationPlans { get; set; }
        public DbSet<ProductionPlan> ProductionPlans { get; set; }
        public DbSet<WorkOperation> WorkOperations { get; set; }
    }
}
