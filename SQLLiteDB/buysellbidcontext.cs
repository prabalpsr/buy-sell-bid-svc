using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;


namespace BuySellBid
{
    public class BuySellBidsContext : DbContext
    {
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Item> Items { get; set; }
//        public DbSet<Seller> Sellers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = PlatformServices.Default.Application.ApplicationBasePath;
            optionsBuilder.UseSqlite("Filename=" + Path.Combine(path, "buysellbid.db"));
        }
    }    
}