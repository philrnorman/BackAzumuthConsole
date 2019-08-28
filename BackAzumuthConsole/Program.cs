using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace BackAzumuthConsole
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Enter your heading: ");
            string input = Console.ReadLine();
            int intHeading;
            int back_azumuth = -1;
            if (int.TryParse(input, out intHeading))
            {
                back_azumuth = GettheBA(intHeading);
            }
            else
            {
                Console.WriteLine("you need to enter a number between 0  and 359");
            }

            Console.WriteLine("Back Azumuth: " + back_azumuth);


            string result = GetUserDetails("United", 5396);
            Console.WriteLine(result);

            // back_azumuth = GettheBA(179);



            Console.ReadLine();
        }

        public static string GetUserDetails(string name, int FlightNumber)

        {
            string info = string.Format("Airline: {0}, Flight Number: {1}", name, FlightNumber);
            return info;
        }

        public static int GettheBA(int heading)

        {
         int BA = -1;

            if (heading >= 0 && heading < 180)
            {
                BA = heading + 180;
            }
            else if (heading > 180 && heading < 360)
            {
                BA = heading - 180;
            }
            else
            {
                Console.WriteLine("Incorrect degree heading was received.");
            }

         return BA;
            
        }

    }


}
