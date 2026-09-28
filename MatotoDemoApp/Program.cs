using System;

namespace ProfitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //extract variables
            double revenue=0.0, costs =0.0;   //input
            double profit=0.0;                //output

            Console.Write("Enter revenue: ");
            revenue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter costs: ");
            costs = Convert.ToDouble(Console.ReadLine());

            profit = revenue - costs;

            Console.WriteLine("Profit = " + profit);
        }
    }
}
