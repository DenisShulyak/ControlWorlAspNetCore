using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiApp.Models;

namespace TaxiApp.DataAccess
{
    public class TaxiContext : DbContext
    {
        public TaxiContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client {Latitude = 20.5, Longitude = 70.4,NumberPhone="+4654651487"},
                new Client {Latitude = 74.8, Longitude = 73.1,NumberPhone="+9856489724"},
                new Client {Latitude = 12.7, Longitude = 60.2,NumberPhone="+4684654878"},
                new Client {Latitude = 68.12, Longitude = 52.41,NumberPhone="+6874545582"}
                );
            modelBuilder.Entity<Driver>().HasData(
                new Driver { NumberCar = "875AKW"},
                new Driver { NumberCar = "824ODQ"},
                new Driver { NumberCar = "184UEN"},
                new Driver { NumberCar = "461LEN"}
                );
            modelBuilder.Entity<Order>().HasData(
                new Order { NumberCar = "824ODQ",PhoneClient= "+9856489724",State = "Waiting" },
                new Order { NumberCar = "461LEN", PhoneClient= "+4654651487", State = "InProcess" }
                );
        }
        
    }
}
