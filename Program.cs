using System;

namespace Ice_Cream_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
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

                  
            } while(!allEqual);
                
             
           
        }
    }
}
