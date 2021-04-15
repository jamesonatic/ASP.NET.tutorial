using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base("name=MyConnString")
        {
            Database.SetInitializer<ShoppingContext>(new CreateDatabaseIfNotExists<ShoppingContext>());
        }
        public virtual DbSet<ShoppingOccasion> ShoppingOccasions { get; set; }
        public virtual DbSet<ShoppingItem>  ShoppingItems { get; set; }
        public virtual DbSet<ShoppingPlace> ShoppingPlaces  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingOccasion>().ToTable("ShoppingOccation");
            modelBuilder.Entity<ShoppingOccasion>().HasKey(x => x.ShoppinOccasionID);
            modelBuilder.Entity<ShoppingOccasion>().Property(x => x.Description).HasMaxLength(50);

            modelBuilder.Entity<ShoppingPlace>().ToTable("ShoppinPlace");
            modelBuilder.Entity<ShoppingPlace>().HasKey(x => x.ShoppingPlaceID);
            modelBuilder.Entity<ShoppingPlace>().Property(x => x.Address).HasMaxLength(200);
            modelBuilder.Entity<ShoppingPlace>().Property(x => x.Name).HasMaxLength(50);

            modelBuilder.Entity<ShoppingItem>().ToTable("ShoppingItem");
            modelBuilder.Entity<ShoppingItem>().HasKey(x => x.ShoppingItemID);
            modelBuilder.Entity<ShoppingItem>().Property(x => x.ItemName).HasMaxLength(50);
            modelBuilder.Entity<ShoppingItem>().Property(x => x.Unit).HasMaxLength(10);

            base.OnModelCreating(modelBuilder);
        }
    }
}
