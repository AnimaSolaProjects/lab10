using lab10.Controle;
using System;

namespace View
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            
            Console.WriteLine("Chose action");
            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine("add");

                    Console.WriteLine("Count of notes:");
                    int count = int.Parse(Console.ReadLine());
                    controller.AddToDb(count);
                    break;
                case 2:
                    Console.WriteLine("Remuve");
                    Console.WriteLine("Enter Title");
                    string name = Console.ReadLine();
                    controller.BeerDelet(name);
                    break;
                case 3:
                    Console.WriteLine("SearchbyName");
                    Console.WriteLine("Enter name");
                    string name2 = Console.ReadLine();
                    controller.SerchByName(name2);
                    break; 
                case 4:
                    Console.WriteLine("SearchbyCompany");
                    Console.WriteLine("Enter company title");
                    string companyName = Console.ReadLine();
                    controller.SerchByName(companyName);
                    break;
                default:
                    break;
            }
        }
    }
}
