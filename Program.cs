using System;
using System.Threading;

namespace Ice_Cream_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
           int attempts = 10;
            int j;
            bool allEqual = false;
            string[] flavours = new string[10];
            do
            {            
                int i = 0;
                while (i < 10)
                {

                    Console.WriteLine("Select your favourite flavour:");
                    Console.WriteLine("1) Chocolate");
                    Console.WriteLine("2) Banana");
                    Console.WriteLine("3) Vanilla");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            flavours[i] = "Chocolate";
                            break;
                        case 2:
                            flavours[i] = "Banana";
                            break;
                        case 3:
                            flavours[i] = "Vanilla";
                            break;
                    }
                    i++;
                }
                allEqual = false;
                for ( j = 1; j <flavours.Length; j++)
                {
                    if (flavours[0] == flavours[j])
                        continue;
                    else
                        break;
                }
                if (j== flavours.Length)
                {
                    allEqual = true;
                }
                  
                attempts--;
                if (attempts < 0)
                {
                    Console.WriteLine("To many attempts");
                    Console.WriteLine("Program is due to exit");
                    Thread.Sleep(2000);
                    System.Environment.Exit(1);
                }

            } while (!allEqual);
            
            Console.WriteLine("All of you have choosen: {0}", flavours[0]);

            Console.ReadKey(true);
           
        }
    }
}
