using System;

namespace CSharpBasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            MultipleOfANumber multipleOfANumber = new MultipleOfANumber();
            multipleOfANumber.multipleOfANumber(num);*/

            /*Console.WriteLine("Enter two number to find GCD : ");
            int n1, n2;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            GCD gCD = new GCD();
            int res = gCD.gcdForLoop(n1, n2);
            Console.WriteLine("GCD using for loop : " + res);
            int res1 = gCD.gcdWhileLoop(n1, n2);
            Console.WriteLine("GCD using while loop : " + res1);*/

            /*LCM lCM = new LCM();
            Console.WriteLine("Enter two number to find LCM : ");
            int num1, num2;
            num1= Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            lCM.lcm(num1, num2);*/

            /*Console.WriteLine("Enter a number to check is it palindrome or not : ");
            int v = Convert.ToInt32(Console.ReadLine());
            Palindrome palindrome = new Palindrome();
            palindrome.palindrome(v);*/

            Console.WriteLine("Enter a number to find how many times it occur in range 50 : ");
            int m = Convert.ToInt32(Console.ReadLine());
            CountDigit countDigit = new CountDigit();
            countDigit.countDigit(m);
        }
    }
}
