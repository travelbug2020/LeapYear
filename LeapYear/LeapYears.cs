using System;

namespace LeapYear
{
    public class LeapYears
    {
        public bool Calculate(int year)
        {

            if (IsDivisibleBy4(year) && year % 100 != 0)
            {
                return true;
            }

            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            if (year % 400 == 0)
            {
                return true;
            }

            if (!IsDivisibleBy4(year))
            {
                return false;
            }

            return false;
        }

        private static bool IsDivisibleBy4(int year)
        {
            return year % 4 == 0;
        }
    }
}
