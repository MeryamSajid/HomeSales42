using System;

class Program
{
    public static void Main(string[] args)
    {
        double danielleTotal = 0;
        double edwardTotal = 0;
        double francisTotal = 0;
        double grandTotal = 0;
        double highTotal = 0;
        string highestSale = "";

        while (true)
        {
            Console.WriteLine("Please enter the initial D, E, or F for the salesperson. Enter Z to exit.");
            string initial = Console.ReadLine().ToUpper();

            if (initial == "Z")
            {
                break;
            }
            else if (initial == "D" || initial == "E" || initial == "F")
            {
                Console.WriteLine("Enter the sale:");

                if (double.TryParse(Console.ReadLine(), out double sale))
                {
                    if (initial == "D")
                    {
                        danielleTotal += sale;
                    }
                    else if (initial == "E")
                    {
                        edwardTotal += sale;
                    }
                    else if (initial == "F")
                    {
                        francisTotal += sale;
                    }

                    grandTotal += sale;

                    if (sale > highTotal)
                    {
                        highTotal = sale;
                        highestSale = initial;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            else
            {
                Console.WriteLine("Error, invalid salesperson entered, please try again");
                
            }
        }

        Console.WriteLine("Grand Total: $" + grandTotal);
        Console.WriteLine("Highest Sale: " + highestSale);
    }
}