using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class LCM
    {
        public void lcm(int n1,int n2)
        {
            int max;
            max = (n1 > n2) ? n1 : n2;
            while(true)
            {
                if(max%n1==0 && max%n2==0)
                {
                    Console.WriteLine("LCM : " + max);
                    break;
                }
                max++;
            }
        }
    }
}
