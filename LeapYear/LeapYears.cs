using System.Runtime.CompilerServices;

namespace LeapYear
{
    public class LeapYears
    {
        public bool Calculate(int year)
        {

            if (year.IsDivisibleBy(4) && !year.IsDivisibleBy(100))
            {
                return true;
            }

            if (year.IsDivisibleBy(100) && !year.IsDivisibleBy(400))
            {
                return false;
            }

            if (year.IsDivisibleBy(400))
            {
                return true;
            }

            return false;
        }
    }

    public static class LeapYearsExtensions
    {
        public static bool IsDivisibleBy(this int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}
