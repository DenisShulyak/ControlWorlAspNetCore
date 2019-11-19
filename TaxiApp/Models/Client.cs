using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApp.Models
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NumberPhone { get; set; }
        public double Longitude { get; set; } 
        public double Latitude { get; set; }
    }
}
