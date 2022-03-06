using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Data
{
    public class ReservationService
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation{ get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public string ServiceName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
