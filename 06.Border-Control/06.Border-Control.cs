using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        IList<IIdeable> allSubgects = new List<IIdeable>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tolkens = input.Split();

            switch (tolkens.Length)
            {
                case 2:
                    allSubgects.Add(new Robot(tolkens[0], tolkens[1]));
                    break;
                case 3:
                    allSubgects.Add(new Citizen(tolkens[0], int.Parse(tolkens[1]), tolkens[2]));
                    break;
            }
        }

        input = Console.ReadLine();

        foreach (var sub in allSubgects.Where(s => s.Id.EndsWith(input)))
        {
            Console.WriteLine(sub.Id);
        }
    }
}
