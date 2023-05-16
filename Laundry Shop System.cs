using System;
namespace laundryShop
{
    class Program
    {
        static void  Main()
        {
        int numOrder = 1;
            double total = 0;
            
			Console.WriteLine("************Welcome************");
			Console.WriteLine("**************to***************");
            Console.WriteLine("********Yun Oh Laundry!********");
            Console.WriteLine("===============================");
            Console.WriteLine("========= Shop price ==========");
            Console.WriteLine("1. 5-9kg   ===========Php180.00");
            Console.WriteLine("2. 10-14kg ===========Php280.00");
            Console.WriteLine("3. 15-20kg ===========Php380.00");
			Console.WriteLine("4. 21-25kg ===========Php480.00");
            Console.WriteLine("===============================");
            
            Console.WriteLine("Select the kilo number of your clothes");
            
            string userInput = Console.ReadLine();
            
            if (userInput == "1") {
                Console.WriteLine("5-9kg  Php180.00");
                Console.WriteLine("Required liter of water");
                Console.WriteLine("3000 L");
                Console.WriteLine("Amount of scoop");
                Console.WriteLine("3 scoops of powder detergent");
            }   
            if (userInput == "2") {
                Console.WriteLine("10-14kg  Php280.00");
                Console.WriteLine("Required liter of water");
                Console.WriteLine("6000 L");
                Console.WriteLine("Amount of scoop");
                Console.WriteLine("6 scoops of powder detergent");
            }   
            if (userInput == "3") {
                Console.WriteLine("15-20kg  Php380.00");
                Console.WriteLine("Required liter of water");
                Console.WriteLine("9000 L");
                Console.WriteLine("Amount of scoop");
                Console.WriteLine("9 scoops of powder detergent");
			}	
			if (userInput == "4") {
                Console.WriteLine("21-25kg  Php80.00");
                Console.WriteLine("Required liter of water");
                Console.WriteLine("12000 L");
                Console.WriteLine("Amount of scoop");
                Console.WriteLine("12 scoops of powder detergent");
				
				Console.WriteLine("Happy Washing!");
            }   
        }
    }
}
