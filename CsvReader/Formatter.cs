using System;
using System.Collections.Generic;
using System.Text;

namespace CSVReaderNestedLists
{
    class Formatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
                return "(Unknown)";
            int popRounded = RoundPopulation4(population);
            return $"{popRounded:### ### ### ###}".Trim();
        }

        private static int RoundPopulation4(int population)
        {
            int accuracy = Math.Max((int)(GetHighestPowerofTen(population) / 10_000l), 1);

            return RoundToNearest(population, accuracy);
        }

        public static int RoundToNearest(int exact, int accuracy)
        {
            int adjusted = exact + accuracy / 2;
            return adjusted - adjusted % 2;
        }

        public static long GetHighestPowerofTen(int x)
        {
            long result = 1;

             while (x > 0)
            {
                x /= 10;
                result *= 10;
            }
            return result;
        }
    }
}
