using System;

namespace LeapYear
{
    public class LeapYears
    {
        public bool Calculate(int year)
        {

            if (IsDivisibleBy4(year) && !IsDivisibleBy100(year))
            {
                return true;
            }

            if (IsDivisibleBy100(year) && year % 400 != 0)
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

        private static bool IsDivisibleBy100(int year)
        {
            return year % 100 == 0;
        }

        private static bool IsDivisibleBy4(int year)
        {
            return year % 4 == 0;
        }
    }
}
