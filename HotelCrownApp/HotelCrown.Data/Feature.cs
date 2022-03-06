using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrownApp.HotelCrown.Data
{
    public class Feature
    {
        public Feature()
        {
            Rooms = new List<RoomFeature> { };
        }
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public List<RoomFeature> Rooms { get; set; }
    }
}
