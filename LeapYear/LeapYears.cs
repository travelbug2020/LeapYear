﻿using System;

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
            else if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }
            else if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 4 != 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
