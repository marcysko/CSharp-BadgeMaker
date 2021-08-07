using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to import API data for badges? type yes or no");
            String response = Console.ReadLine();

            if (response == "yes")
            {
                List<Employee> employees = PeopleFetcher.GetFromApi();
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }
            else if (response == "no")
            {
                List<Employee> employees = PeopleFetcher.GetEmployees();
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }
            else 
            {
                Console.Write("Invalid Response");
            }
        }
    }
}
