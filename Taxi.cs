using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Taxi
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            string result = OnDuty ? "Yes" : "No";
            Console.WriteLine("On Duty : {0}", result);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
            } else
            {
                Console.WriteLine("{0} tidak sedang menjemput penumpang", DriverName);
            }
        }

        public void DropOffPassenger()
        {
            if (NumPassenger!=0)
            {
                Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
            } else
            {
                Console.WriteLine("{0} belum selesai mengantar penumpang", DriverName);
            }
        }

    }
}
