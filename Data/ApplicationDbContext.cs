using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QadduraResturant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<subCategory> subCategory { get; set; }
        public DbSet<MenuItem> MenuItem  { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<AppUser> ApplicationUser { get; set; }
        public DbSet<ShoppingCard> ShoppingCard { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


    }
}
