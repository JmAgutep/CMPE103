using System;
using System.Collections.Generic;
namespace laundryShop
{
    class Program
    {
        static void  Main()
        {
            double total = 0;

            
            priceList ();
            Console.WriteLine("Select the kilo number of your clothes");

            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
            yunohOne ();
            total = 180;
            Console.WriteLine("Your total payment" + total);
            }

            if (userInput == 2)
            {
            yunohTwo ();
            total = 180;
            Console.WriteLine("Your total payment" + total);
            }

            if (userInput == 3)
            {
            yunohThree ();
            total = 180;
            Console.WriteLine("Your total payment" + total);
            }

            if (userInput == 4)
            {
            yunohFour ();
            total = 180;
            Console.WriteLine("Your total payment" + total);
            }
        }
        static void priceList ()
        {
            var priceList = new List<string>()
            {
              "*********  Welcome to  ********", 
              "******* Yun Oh Laundry! *******",
              "===============================",
              "========= Shop Price ==========",
              "1. 5-9kg   ========== Php180.00",
              "2. 10-14kg ========== Php280.00",
              "3. 15-20kg ========== Php380.00",
              "4. 21-25kg ========== Php480.00",
              "===============================",

            };
            foreach (string i in priceList)
            {
              Console.WriteLine(i);
            }
        }
        static void yunohOne ()
        {
            var yunohOne = new List<string>()
            {
              "5-9kg",
              "3000 L",
              "Amount of scoop",
              "3 scoops of powder detergent",
              "Duration time: 1 hour",
              "Total bill: Php180.00",
              "Happy Washing!"

            };
            foreach (string i in yunohOne)
            {
                Console.WriteLine(i);
            }
        }
        static void yunohTwo ()
        {
            var yunohTwo = new List<string>()
            {
              "10-14kg",
              "6000 L",
              "Amount of scoop",
              "6 scoops of powder detergent",
              "Duration time: 2 hour",
              "Total bill: Php280.00",
              "Happy Washing!"

            };
            foreach (string i in yunohTwo)
            {
                Console.WriteLine(i);
            }
        }
        static void yunohThree ()
        {
            var yunohThree = new List<string>()
            {
              "15-20kg",
              "9000 L",
              "Amount of scoop",
              "9 scoops of powder detergent",
              "Duration time: 3 hour",
              "Total bill: Php380.00",
              "Happy Washing!"
            };
            foreach (string i in yunohThree)
            {
                Console.WriteLine(i);
            }
        }
        static void yunohFour ()
        {
            var yunohFour = new List<string>()
            {
              "21-25 kg",
              "12000 L",
              "Amount of scoop",
              "12 scoops of powder detergent",
              "Duration time: 4 hour",
              "Total bill: Php480.00",
              "Happy Washing!"
            };
            foreach (string i in yunohFour)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
