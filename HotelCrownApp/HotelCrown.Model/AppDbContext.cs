using HotelCrownApp.HotelCrown.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString="server=.;database=HotelCrownDB;uid=sa;password=123;";
        }
        public DbSet<Room> Rooms  { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<RoomFeature> RoomFeatures { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationCustomer> ReservationCustomers { get; set; }
        public DbSet<ReservationService> ReservationServices { get; set; }
        
    }
}
