using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentISAAPI.Model
{
    public class HotelDetail
    {
        [Key]
        
        public int HotelCode { get; set; }
        public string HotelName { get; set; }
        public double TotalRate { get; set; }
        public string Address { get; set; }
        public string StarLevel { get; set; }
        public string hotelMainImage { get; set; }
        public string policiesAndDisclaimer { get; set; }
        public string HotelDescriptions { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Currency { get; set; }

    }
}
