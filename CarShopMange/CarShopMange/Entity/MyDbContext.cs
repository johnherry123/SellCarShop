using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMange.Entity
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=SQLiteConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyDbContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.userID, ur.roleID });  

            modelBuilder.Entity<UserRole>()
                .HasRequired(ur => ur.user) 
                .WithMany(u => u.userRole) 
                .HasForeignKey(ur => ur.userID);  

            modelBuilder.Entity<UserRole>()
                .HasRequired(ur => ur.role) 
                .WithMany(r => r.userRole) 
                .HasForeignKey(ur => ur.roleID); 
        }
    }
}
