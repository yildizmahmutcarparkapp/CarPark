using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Models
{
    public class cities
    {
        public string name { get; set; }
        public string plate { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string[] counties { get; set; }
    }
}
