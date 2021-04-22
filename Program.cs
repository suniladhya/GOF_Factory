using System;

namespace GOF_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanFactory planFactory = new PlanFactory();

            int unit = 100;
            string planType = "INSTITUTIONALPLAN";

            Plan p = planFactory.getPlan(planType);
            p.getRate();
            p.calculateBill(unit);

            Console.ReadKey();

        }
    }
}
