﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GreatestVariables
{
    class GreatestNum
    {
        //Method to compare which is greater
        public int LargestNumber(int number1, int number2, int number3)
        {
            if ((number1.CompareTo(number2) > 0) && (number1.CompareTo(number3) > 0))
            {
                return number1;
            }
            else if ((number2.CompareTo(number1) > 0) && (number2.CompareTo(number3) > 0))
            {
                return number2;
            }
            else if ((number3.CompareTo(number2) > 0) && (number3.CompareTo(number1) > 0))
            {
                return number3;
            }
            else
            {
                return 0;
            }
        }
    }
}
