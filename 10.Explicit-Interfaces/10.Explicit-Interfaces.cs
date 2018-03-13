using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        IList<Citizen> citizens = new List<Citizen>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tolk = input.Split();
            citizens.Add(new Citizen(tolk[0], tolk[1], int.Parse(tolk[2])));
        }

        foreach (var citizen in citizens)
        {
            IResident iResident = citizen;
            IPerson iPerson = citizen;
            Console.WriteLine(iPerson.GetName());
            Console.WriteLine(iResident.GetName());
        }
    }
}
