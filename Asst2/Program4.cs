using System;
using System.Globalization;

namespace Asst2
{
    public class Program4
    {
        public static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            Bank b = new Bank(p, y);

            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 2;

            Console.WriteLine(b.simpleInterest().ToString("N", setPrecision));
            Console.WriteLine(b.compInterest().ToString("N", setPrecision));
        }
    }

    interface Interest
    {
        int Rate { get;}

        double simpleInterest();
        double compInterest();
    }

    class Bank : Interest
    {
        int principal;
        float year;

        public Bank(int p, float y) {
            this.principal = p;
            this.year = y;
        }

        public int Rate { get => 25;}

        public double compInterest()
        {
            return (this.principal * Math.Pow((1.0f + (this.Rate / 100.0f)), this.year)) - this.principal;
        }

        public double simpleInterest()
        {
            return this.principal * this.Rate * this.year / 100;
        }
    }
}
