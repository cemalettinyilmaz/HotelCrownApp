using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Data
{
    public class ReservationCustomer
    {
        public int Id { get; set; }
        public virtual int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
