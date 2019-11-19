using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApp.Models
{
    enum State {
    Waiting,
    InProcess,
    End
    }

    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string State { get; set; } 
        public string PhoneClient { get; set; }
        public string NumberCar { get; set; }
         
    }
}
