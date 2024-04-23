using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User04_Nikolaev.Context.Models;

namespace User04_Nikolaev.Context
{
    public class RepairServiceContext:DbContext
    {
       
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public RepairServiceContext():base("con")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasMany(x => x.RequestWorkers)
                .WithOptional(c => c.Worker)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
              .HasMany(x => x.RequestClients)
              .WithRequired(c => c.Client)
              .WillCascadeOnDelete(false);
        }
    }
}
