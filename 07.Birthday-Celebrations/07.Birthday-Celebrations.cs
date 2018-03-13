using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        IList<ICitizen> allSubgects = new List<ICitizen>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] tolkens = Console.ReadLine().Split();

            switch (tolkens.Length)
            {
                case 3:
                    allSubgects.Add(new Rebel(tolkens[0], int.Parse(tolkens[1]), tolkens[2]));
                    break;
                case 4:
                    allSubgects.Add(new Citizen(tolkens[0], int.Parse(tolkens[1]), tolkens[2], tolkens[3]));
                    break;
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            if (allSubgects.Any(s => s.Name == input))
            {
                ICitizen sub = allSubgects.First(s => s.Name == input);
                sub.BuyFood();
            }
        }

        Console.WriteLine(allSubgects.Sum(s => s.Food));
    }
}
