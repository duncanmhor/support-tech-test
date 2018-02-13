using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTechTest.Models.Nestoria
{
    public class Location
    {
        public double center_lat { get; set; }
        public double center_long { get; set; }
        public string long_title { get; set; }
        public string place_name { get; set; }
        public string title { get; set; }
    }
}