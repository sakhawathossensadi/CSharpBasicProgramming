using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class CountDigit
    {
        public void countDigit(int num)
        {
            int i,b,count=0;
            for(i=1;i<=50;i++)
            {
                int n = i;
                while(n!=0)
                {
                    b = n % 10;
                    Console.WriteLine("b : " + b);
                    if(b==num)
                    {
                        count++;
                    }
                    n = n / 10;
                    Console.WriteLine("n : " + n);
                }
            }
            Console.WriteLine("Count : "+count);
        }
    }
}
