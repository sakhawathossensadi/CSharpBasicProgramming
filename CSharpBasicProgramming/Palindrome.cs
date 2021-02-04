using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class Palindrome
    {
        public void palindrome(int num)
        {
            int n = num;
            int value = 0;
            int b;
            while(num!=0)
            {
                b = num % 10;
                value = (value * 10) + b;
                num = num / 10;
            }

            if(n==value)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
