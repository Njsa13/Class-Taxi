using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi1 = new Taxi();
            Taxi taxi2 = new Taxi();

            //pemanggilan properties
            taxi1.DriverName = "Jono";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 10;

            //pemanggilan method
            taxi1.TaxiInfo();
            Console.WriteLine();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassenger();

            //pemanggilan properties
            taxi2.DriverName = "Supri";
            taxi2.OnDuty = false;
            taxi2.NumPassenger = 0;

            Console.WriteLine("\n--------------------------------------------------------------------\n");

            //pemanggilan method
            taxi2.TaxiInfo();
            Console.WriteLine();
            taxi2.PickUpPassenger();
            taxi2.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
