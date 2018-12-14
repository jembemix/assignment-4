using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int childTickets;
            int adultTickets;
            int seniorTickets;
            double totalTickets = 0;
            double totalticketsCost = 0;
            double totalConcesssionCost = 0;

            Console.WriteLine("welocome to the Movie!");
            Console.WriteLine("How many Child Tickets");
            childTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("How many adult tickets?");
            adultTickets = int.Parse(Console.ReadLine());


            Console.WriteLine("How many senior tickets?");
            seniorTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Is it going to be a Evening or Matinee show");
            Console.WriteLine("Pick 2 for Evening or 1 for Matinee ");

            string movieTime = Console.ReadLine();

            if (movieTime == "2")
            {
                double ChildPrice = 6.99;
                double adultPrice = 10.99;
                double seniorPrice = 8.50;
                totalTickets += childTickets * ChildPrice;
                totalticketsCost += adultTickets * adultPrice;
                totalTickets += seniorTickets * seniorPrice;

            }
            else if (movieTime == "1")

            {
                double ChildPrice = 3.99;
                double adultPrice = 5.99;
                double seniorPrice = 4.50;
                totalTickets += childTickets * ChildPrice;
                totalticketsCost += adultTickets * adultPrice;
                totalTickets += seniorTickets * seniorPrice;


            }
            else

            {
                Console.WriteLine("Please it might be an invalid show time");

            }

            int totalTicketCount = childTickets + adultTickets + seniorTickets;

            double smallSodasCost = 3.50;
            double largeSodaCost = 5.99;
            double hotDogCost = 3.99;
            double popcornCost = 4.50;
            double CandyCost = 1.99;

            int smallSodaCount = 0;
            int largeCount = 0;
            int largeCount = 0;
            int hotDog = 0;
            int popcornCount = 0;
            int CandyCount = 0;

            Console.WriteLine(" How many Sodas do you like");
            smallSodasCount = int.Parse(Console.ReadLine());


            Console.WriteLine("How many large Sodas do you like");

            largeSodasCount = int.Parse(Console.ReadLine());

            Console.WriteLine("How many hot dog do you like");
            hotDogCount = int.Parse(Console.ReadLine());

            Console.WriteLine("How many popcorns do you like");
            popcornsCount = int.Parse(Console.ReadLine());

            Console.WriteLine("How many candys do you  like");
            CandyCount = int.Parse(Console.ReadLine());


            totalConcessionCost += smallSodaCount * smallSodasCost;
            totalConcessionCost += largeSodaCount * largeSodasCost;
            totalConcessionCost += hotDogCount * hotDogCost;
            totalConcessionCost += popcornCount * popcornCost;
            totalConcessionCost += CandyCost * CandyCost;


            double firstDiscount = 0;
            double secondDicount = 0;
            double thirdDiscount = 0;

            if (popcornCount >= 1 && largeSodaCount >= 1 && totalTicketCount >= 1)
            {
                if (popcornCount <= largeSodaCount && popcornCount <= totalTicketCount <= totalTicketCount)
                {
                    firstDiscount = 2 * largeSodaCount;
                }
                else if (largeSodaCount <= popcornCount && largeSodaCount <= totalTicketCount)
                {
                    firstDiscount = 2 * largeSodaCount;
                }
                else
                {
                    firstDiscount = 2 * totalTicketCount;
                }

            }


            if (totalTicketCount >= 3)
            {

                if (movieTime == "2")
                {
                    if (popcornCount >= 1)
                    {
                        secondDiscount = 4.50;
                    }
                }

            }

            if (CandyCount >= 4)
            {
                thirdDiscount = (CandyCount / 4) * 1.99)
                }
            double discountAmount = firstDiscount + secondDiscount + thirdDiscount;
            double totalCost = (totalTicketCost + totalConscessionCot) - discountAmount;
            Console.WriteLine("The total cost is $" + totalCost);
            Console.WriteLine();
            Console.WriteLine(drug any key to continue...");
            Console.ReadKey();
        }
    }
}


                    







                    
















                    *
















