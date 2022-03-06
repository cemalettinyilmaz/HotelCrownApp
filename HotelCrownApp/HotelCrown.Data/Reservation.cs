using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Data
{
    public class Reservation
    {
        public Reservation()
        {
            Customers=new List<ReservationCustomer> ();
            Services=new List<ReservationService> ();
        }
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate{ get; set; }
        public bool? CheckedInTime { get; set; }
        public bool? CheckedOutTime { get; set; }
        public virtual List<ReservationCustomer> Customers { get; set; }
        public virtual List<ReservationService> Services { get; set; }
    }
}
