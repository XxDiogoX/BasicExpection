using System;
using System.Globalization;
using ExercicioException.Entities;
using ExercicioException.Entities.Exceptions;

namespace ExercicioException
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                
                

                    Console.WriteLine("Enter account data:");
                    Console.WriteLine("Number of account:");
                    Console.Write("Number: ");
                    int numberaccount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Name of holder:");
                    Console.Write("Name: ");
                    string nameholder = Console.ReadLine();
                    Console.WriteLine("Enter with value balance:");
                    Console.Write("Value: ");
                    double valueinitial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Enter with value withdraw limit:");
                    Console.Write("Value: ");
                    double valuewithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Account account = new Account(numberaccount, nameholder, valueinitial, valuewithdraw);
                    Console.WriteLine();
                    Console.WriteLine(account);
                    Console.WriteLine();
                    Console.WriteLine("Enter amount  for withdraw:");
                    Console.Write("Value: ");
                    double bavalue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.WithDraw(bavalue);
               
                   
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
    }
}
