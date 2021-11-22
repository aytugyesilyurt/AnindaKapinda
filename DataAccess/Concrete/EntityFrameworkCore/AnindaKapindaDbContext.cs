using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class AnindaKapindaDbContext : DbContext
    {
        public AnindaKapindaDbContext(DbContextOptions<AnindaKapindaDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=AnindaKapindaDb;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User user = new User
            {
                UserId = 1,
                FirstName = "Aytuğ",
                LastName = "Yeşilyurt",
                Mail = "yesilyurt.aytug@hotmail.com",
                Password = "aytug123",
                IsActive = true
            };
            modelBuilder.Entity<User>().HasData(user);

            //modelBuilder.Entity<Product>()
            //            .HasOne(e => e.Category)
            //            .WithMany(c => c.Products);

            Category category = new Category
            {
                CategoryId = 1,
                Name = "İçecek"
            };
            modelBuilder.Entity<Category>().HasData(category);

            Product product = new Product
            {
                ProductId = 1,
                CategoryId = 1,
                Name = "su",
                Price = 1,
                Description = "su"
                
            };
            modelBuilder.Entity<Product>().HasData(product);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Address> Adresses { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<BasketDetail> BasketDetails { get; set; }
    }
}
