using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class FactorialRecursion
    {
        public int factorialRecursion(int num)
        {
            if(num==0 || num==1)
            {
                return 1;
            }
            else
            {
              return  num*factorialRecursion(num-1);
            }
        }
    }
}
