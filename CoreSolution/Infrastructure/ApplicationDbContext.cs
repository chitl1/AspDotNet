using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        //lop nay cho phep chi dinh cau hinh mà khong can sua lop thuc the
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.Property(e => e.Price).HasColumnType("decimal(18,0)");
            //});
        }

    }
}
