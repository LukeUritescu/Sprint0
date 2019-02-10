using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester test = new Tester();
            test.Test();
            Console.ReadLine();
        }
    }

    class Tester
    {
        public void Test()
        {
            Console.WriteLine("Flying Vehicle Tester");
            Console.WriteLine("\nAirplane.cs");

            //Airplane class tests
            Airplane ap = new Airplane();
            Console.WriteLine(ap.About());

            Console.WriteLine("\nAirplaneTakeOffTests.");
            Console.WriteLine("\nCall ap.TakeOff():");
            //This will fail
            Console.WriteLine(ap.TakeOff());
            Console.WriteLine("\nCall ap.StartEngine():");
            ap.StartEngine();
            Console.WriteLine(ap.TakeOff());

            //Fly up
            Console.WriteLine("\nFly up Tests");
            Console.WriteLine("\n Call ap.FlyUp() fly to 1,000ft default");
            ap.FlyUp();
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Flly up to 45,000ft:");
            ap.FlyUp(44000);
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(40000) Fly up another 40,000ft");
            ap.FlyUp(40000);
            Console.WriteLine(ap.About());

            //Land
            Console.WriteLine("\nFly Down");
            Console.WriteLine("Call ap.FlyDown(50000) Fly Down 50,000ft");
            ap.FlyDown(50000);
            Console.WriteLine(ap.About());
            Console.WriteLine("Call ap.FlyDown(ap.CurrentAltitude) this should land");
            ap.FlyDown(ap.CurrentAltitude);
            Console.WriteLine(ap.About());

        }
    }
}
