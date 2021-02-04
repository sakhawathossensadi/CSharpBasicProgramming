using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicProgramming
{
    class FibonacciUsingArray
    {
        public void fibonacciUsingArray(int num)
        {
            //int z = Convert.ToInt32(num);
            int[] arr = new int[num+1];
            arr[0] = 0;
            arr[1] = 1;
            int i;
            for(i=2;i<=num;i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            for(i=0;i<=num;i++)
            {
                Console.WriteLine(i + " fibonacci : " + arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Fibonacii of : "+num+ " is :"+arr[num]);
        }
    }
}
