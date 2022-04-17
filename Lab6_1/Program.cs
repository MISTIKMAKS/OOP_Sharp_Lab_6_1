using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s1 = new Solution();
            Console.WriteLine("Solution: {0}", Solution.GetCounter());
            Console.WriteLine("Solution::Liquid: {0}", Solution.Liquid.GetCounter());
            Console.WriteLine("s1: {0}", s1.ToString());
            Console.WriteLine();

            Solution s2 = new Solution();
            s2.Read();
            Console.WriteLine();
            Console.WriteLine("Solution local: {0}", Solution.GetCounter());
            Console.WriteLine("Solution::Liquid local: {0}", Solution.Liquid.GetCounter());
            Console.WriteLine("s2: {0}", s2.ToString());
            Console.WriteLine();

            Solution s3 = new Solution("Tea", 1000, 50);
            Console.WriteLine("Solution local: {0}", Solution.GetCounter());
            Console.WriteLine("Solution::Liquid local: {0}", Solution.Liquid.GetCounter());
            Console.WriteLine("s3: {0}", s3.ToString());
            Console.Write("Change Liquid Quantity: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            s3.SetLiquidQuantity(temp);
            Console.WriteLine("s3(changed): {0}", s3.ToString());
            Console.WriteLine();

            s3++;
            Console.WriteLine("s3++: {0}", s3.ToString());
            s3--;
            Console.WriteLine("s3--: {0}", s3.ToString());
            ++s3;
            Console.WriteLine("++s3: {0}", s3.ToString());
            --s3;
            Console.WriteLine("--s3: {0}", s3.ToString());

            Console.ReadKey();
        }
    }
}
