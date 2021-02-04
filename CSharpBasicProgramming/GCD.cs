using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class GCD
    {
        public int gcdForLoop(int n1,int n2)
        {
            int i, gcd=0;
            for(i=1;i<=n1&&i<=n2;i++)
            {
                if(n1%i==0 && n2%i==0)
                {
                    gcd = i;
                }
            }
            return gcd;
        }

        public int gcdWhileLoop(int n1,int n2)
        {
            while(n1!=n2)
            {
                if(n1>n2)
                {
                    n1 = n1 - n2;
                }
                else
                {
                    n2 = n2 - n1;
                }
            }
            return n1;
        }
    }
}
