using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public virtual string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
    }
    public enum Gender
    {
        Female,Male
    }
}
