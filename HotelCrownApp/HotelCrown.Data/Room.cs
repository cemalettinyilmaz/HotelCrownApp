using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Data
{
    public class Room
    {
        public Room()
        {
              Features=new List<RoomFeature> { };
        }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public List<RoomFeature> Features { get; set; }
    }
}
