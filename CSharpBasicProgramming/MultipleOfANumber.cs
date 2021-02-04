using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class MultipleOfANumber
    {
        public void multipleOfANumber(int num)
        {
            int i;
            for(i=num;i<=200;i++)
            {
                if(i%num==0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
