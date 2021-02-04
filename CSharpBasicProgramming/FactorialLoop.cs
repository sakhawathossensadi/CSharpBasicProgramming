using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class FactorialLoop
    {
        public void factorialLoop(int num)
        {
            int i,factorial = 1;
            for(i=1;i<=num;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial : " + factorial);
        }
    }
}
