using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Lab6_1
{
    class Solution
    {
        private Liquid liquid;
        double liquid_quantity;
        static int counter;
        public class Liquid
        {
            private string liquid_name;
            private double liquid_density;
            private static int counter = 0;
            public Liquid()
            {
                liquid_name = "";
                liquid_density = 0.0;
                counter++;
            }
            public Liquid(string liquid_name, double liquid_density)
            {
                this.liquid_name = liquid_name;
                this.liquid_density = liquid_density;
                counter++;
            }
            public Liquid(Liquid l)
            {
                this.liquid_name = l.liquid_name;
                this.liquid_density = l.liquid_density;
                counter++;
            }
            public string GetLiquidName() 
            { 
                return this.liquid_name; 
            }
            public double GetLiquidDensity() 
            { 
                return this.liquid_density; 
            }
            public static int GetCounter() 
            { 
                return counter; 
            }
            public void SetLiquidName(string liquid_name) 
            { 
                this.liquid_name = liquid_name; 
            }
            public void SetLiquidDensity(double liquid_density) 
            { 
                this.liquid_density = liquid_density; 
            }
            public bool Init(string liquid_name, double liquid_density)
            {
                if (liquid_density > Math.Pow(10, -33) && liquid_density < Math.Pow(10, 14))
                {
                    SetLiquidName(liquid_name);
                    SetLiquidDensity(liquid_density);
                    return true;
                }
                return false;
            }
            public void Display()
            {
                Console.WriteLine("Liquid Name: {0}, Liquid Density: {1}", liquid_name, liquid_density);
            }
            public void Read()
            {
                String name;
                double density;
                do
                {
                    Console.WriteLine("Liquid Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Liquid Density: ");
                    density = Convert.ToDouble(Console.ReadLine());
                } while (!Init(name, density));
            }
            public static Liquid operator ++(Liquid l) 
            { 
                return new Liquid(l.liquid_name, l.liquid_density++); 
            }
            public static Liquid operator --(Liquid l) 
            { 
                return new Liquid(l.liquid_name, l.liquid_density--); 
            }
            public override string ToString()
            {
                return "Liquid: [Liquid Name: " + this.liquid_name + ", " + "Liquid Density: " + this.liquid_density + "]";
            }
        }
        public Solution()
        {
            this.liquid = new Liquid();
            this.liquid_quantity = 0.0;
            counter++;
        }
        public Solution(Liquid liquid, double liquid_quantity)
        {
            this.liquid = liquid;
            this.liquid_quantity = liquid_quantity;
            counter++;
        }
        public Solution(Solution solution)
        {
            this.liquid = solution.liquid;
            this.liquid_quantity = solution.liquid_quantity;
            counter++;
        }
        public Solution(String liquid_name, double liquid_density, double liquid_quantity)
        {
            this.liquid_quantity = liquid_quantity;
            this.liquid = new Liquid(liquid_name, liquid_density);
            counter++;
        }
        public Liquid GetLiquid() 
        { 
            return this.liquid; 
        }
        public double GetQuantity() 
        { 
            return this.liquid_quantity; 
        }
        public static int GetCounter() 
        { 
            return counter; 
        }
        public void SetLiquid(Liquid liquid) 
        { 
            this.liquid = liquid; 
        }
        public void SetLiquidQuantity(double liquid_quantity) 
        { 
            this.liquid_quantity = liquid_quantity; 
        }
        public void Display()
        {
            Console.WriteLine("Liquid Quantity: {0}", this.liquid_quantity);
            this.liquid.Display();
        }
        public void Read()
        {
            string name;
            double density;
            double quantity;
            do
            {
                Console.WriteLine("Liquid Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Liquid Density: ");
                density = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Liquid Quantity: ");
                quantity = Convert.ToDouble(Console.ReadLine());
            } while (!this.liquid.Init(name, density));
            this.liquid_quantity = quantity;
        }
        public static Solution operator ++(Solution solution)
        {
            return new Solution(solution.liquid++, solution.liquid_quantity++);
        }
        public static Solution operator --(Solution solution)
        {
            return new Solution(solution.liquid--, solution.liquid_quantity--);
        }
        public override string ToString()
        {
            return "Liquid: {" + this.liquid.ToString() + ", " + "Quantity: " + this.liquid_quantity + "}";
        }
    }
}