using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
            //HÄR SKAPAR JAG MIN BASKLASS SOM HETER "VEHICLE".
    public class Vehicle
    {
     

            //NU LÄGGER JAG TILL EN METOD FÖR BASKLASSEN VEHICLE

        public void Move()
        {
            Console.WriteLine("This vehicle is moving.");
        }

        public void Stop()
        {
            Console.WriteLine("This vehicle is slowing down.");
        }

    }

        //HÄR SKAPAR JAG MIN SUBKLASS: "CARS" SOM KOMMER ÄRVA ATTRIBUT OCH METODER FRÅN "VEHICLE".

    public class Car : Vehicle
    {

        public new void Move()
        {
            Console.WriteLine("This car is moving");
        }
    }
}
