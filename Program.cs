using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassTaxi{
    class Program{
        static void Main(string[] args){
            Taxi taxi = new Taxi();

            taxi.DriverName = "Joko";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        }
    }
}