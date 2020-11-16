using System;

namespace LeapYear
{
    public class LeapYears
    {
        public bool Calculate(int year)
        {

            if (year % 4 == 0 && year % 100 != 0)
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

            if (year % 4 != 0)
            {
                return false;
            }

            return false;
        }
    }
}
