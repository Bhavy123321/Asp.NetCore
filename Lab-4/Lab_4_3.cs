using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.Net_Sem_5
{
    class RBI
    {
        public virtual int calculateInterest(int p, int r, int t)
        {
            int ans = (p * r * t) / 100;
            return ans;
        }
    }

    class HDFC : RBI
    {
        public override int calculateInterest(int p, int r, int t)
        {
            int ans = (p * (r + 1) * t) / 100;
            return ans;
        }
    }

    class SBI : RBI
    {
        public override int calculateInterest(int p, int r, int t)
        {
            int ans = (p * (r + 1) * t) / 200;
            return ans;
        }
    }

    class ICICI : RBI
    {
        public override int calculateInterest(int p, int r, int t)
        {
            int ans = (p * (r + 2) * t) / 200;
            return ans;
        }
    }

    public class Lab_4_3
    {
        public void method()
        {
            Console.WriteLine("=== Bank Interest Calculator ===\n");

            RBI rbi = new RBI();
            HDFC hdfc = new HDFC();
            SBI sbi = new SBI();
            ICICI icici = new ICICI();

            Console.Write("Enter Principal Amount: ");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate of Interest (%): ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Time (years): ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== Interest Calculations ===");

            int rbiInterest = rbi.calculateInterest(principal, rate, time);
            int hdfcInterest = hdfc.calculateInterest(principal, rate, time);
            int sbiInterest = sbi.calculateInterest(principal, rate, time);
            int iciciInterest = icici.calculateInterest(principal, rate, time);

            Console.WriteLine($"RBI Base Interest: {rbiInterest}");
            Console.WriteLine($"HDFC Interest: {hdfcInterest}");
            Console.WriteLine($"SBI Interest: {sbiInterest}");
            Console.WriteLine($"ICICI Interest: {iciciInterest}");

            Console.WriteLine("\n=== Detailed Comparison ===");
            Console.WriteLine($"Principal: {principal}");
            Console.WriteLine($"Base Rate: {rate}%");
            Console.WriteLine($"Time: {time} years");
            Console.WriteLine();
            Console.WriteLine("Bank\t\tInterest\tExtra Benefit");
            Console.WriteLine("----\t\t--------\t-------------");
            Console.WriteLine($"RBI\t\t{rbiInterest}\t\tBase Rate");
            Console.WriteLine($"HDFC\t\t{hdfcInterest}\t\t+1%");
            Console.WriteLine($"SBI\t\t{sbiInterest}\t\t+0.5%");
            Console.WriteLine($"ICICI\t\t{iciciInterest}\t\t+1.5%");

            int maxInterest = Math.Max(Math.Max(rbiInterest, hdfcInterest),
                                     Math.Max(sbiInterest, iciciInterest));

            Console.WriteLine($"\nBest Offer: {maxInterest}");

            if (maxInterest == hdfcInterest)
                Console.WriteLine("HDFC offers the best interest rate!");
            else if (maxInterest == sbiInterest)
                Console.WriteLine("SBI offers the best interest rate!");
            else if (maxInterest == iciciInterest)
                Console.WriteLine("ICICI offers the best interest rate!");
            else
                Console.WriteLine("RBI base rate is the best!");

            Console.WriteLine("\n=== Program Complete ===");
        }
    }
}
