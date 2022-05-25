using System;
using System.Collections.Generic;

namespace Sparky
{
    public class Calculator
    {
        public List<int> NumberRange = new();
        public int AddNumbers(int a, int b)
        {
            return a + b;       
        }

        public bool IsOdd(int a) //impar odd
        {
            return a % 2 != 0; // if module is different than 0, then is odd
        }

        public List<int> GetOddRange(int min, int max)
        {
            //Returns the odd numbers between the range given
            for(int i = min; i<= max; i++)
            {
                if(i %2 != 0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange; 
        }

    }
}
