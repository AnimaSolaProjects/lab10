using lab10.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace lab10.Controle
{
    public class Controller
    {
        public UserContext userContext = new UserContext();
        public Random Rand = new Random();
        

        public void AddToDb(int count)
        {
            Beer[] beers = new Beer[count];
            Console.WriteLine("Enter the Name of company");
            string name = Console.ReadLine();
            Console.WriteLine("Enter year of company");
            int year = int.Parse(Console.ReadLine());
            Сompany company = new Сompany
            {
                Name = name,
                Year = year,
            };

            for (int i = 0; i < count; i++)
            {
                beers[i] = new Beer();
                Console.WriteLine("enter title");
                beers[i].Title = Console.ReadLine();

                Console.WriteLine("enter avarge price");
                beers[i].Average_price = float.Parse(Console.ReadLine());

                company.Beers.Add(beers[i]);
                
                userContext.Beers.AddRange(beers);
                userContext.SaveChanges();
            }
        }

        public void BeerDelet(string name)
        {
            Beer beer = userContext.Beers.FirstOrDefault(x => x.Title == name);
            userContext.Beers.Remove(beer);
            userContext.SaveChanges();
        }
        public void SerchByName(string name)
        {
            List<Beer> beers = new List<Beer>();
            beers = userContext.Beers.Where(x => x.Title == name).ToList();
            foreach (var item in beers)
            {
                Console.WriteLine($"Title of Beer{item.Title}, Price of beer {item.Average_price}, Company of beeer {item.Сompany}");
            }
        }
        public void CompanySearch(string name) 
        {
            List<Beer> beers = new List<Beer>();
            beers = userContext.Beers.Where(x => x.Сompany.Name == name).ToList();
            foreach (var item in beers)
            {
                Console.WriteLine($"Title of Beer{item.Title}, Price of beer {item.Average_price}, Company of beeer {item.Сompany}");
            }
        }
    }
}
