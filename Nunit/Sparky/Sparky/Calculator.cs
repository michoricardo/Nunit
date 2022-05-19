using System;

namespace Sparky
{
    public class Calculator
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;       
        }

        public bool IsOdd(int a) //impar odd
        {
            return a % 2 != 0; // if module is different than 0, then is odd
        }

    }
}
