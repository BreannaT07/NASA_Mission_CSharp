using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_Mission_CSharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = 36500; // kg
            double distanceToMoon = 7589000; // km
            double fuel = CalulateFuel(weight, distanceToMoon);
            Console.WriteLine($"The fuel needed for the mission to the Moon is: {fuel} kg");
            string missionStatus = CheckMissionStatus(fuel, false);
            Console.WriteLine(missionStatus);

            Console.ReadKey();
        }

        // Step 1
        public static double CalulateFuel(double weight, double distance)
        {
            double fuelNeeded = weight * distance * 0.015;
            return fuelNeeded;
        }
        // Step 2
        public static string CheckMissionStatus(double fuellevel, bool crewReady)
        {
            if (fuellevel < 100000)
            {
                return "Warning: Not enough fuel for the mission.";
            }
            else if (!crewReady)
            {
                return "Warning: Crew is not ready for the mission.";
            }
            else
            {
                return "Mission is ready for launch!";
            }

            // Returns in methonds are important because it defines and constrains the data type of the returning value
            // It makes the code flexible with returning the statemnet without using an expression to terminate a function early
        }
    }
}
