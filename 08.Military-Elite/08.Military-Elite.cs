using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        IList<ISoldier> soldiers = new List<ISoldier>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] args = input.Split();

            switch (args[0])
            {
                case "Private":
                    soldiers.Add(new Private(int.Parse(args[1]), args[2], args[3], double.Parse(args[4])));
                    break;
                case "LeutenantGeneral":
                    IList<ISoldier> privates = ExtractPrivets(args.Skip(5).ToList(), soldiers);
                    soldiers.Add(new LeutenantGeneral(int.Parse(args[1]), args[2], args[3], double.Parse(args[4]), privates));
                    break;
                case "Engineer":
                    if (args[5] == "Airforces" || args[5] == "Marines")
                    {
                        IList<IRepair> repairs = ExtractRepairs(args.Skip(6).ToList());
                        soldiers.Add(new Engineer(int.Parse(args[1]), args[2], args[3], double.Parse(args[4]), args[5], repairs));
                    }
                    break;
                case "Commando":
                    if (args[5] == "Airforces" || args[5] == "Marines")
                    {
                        IList<IMission> missions = ExtractMissions(args.Skip(6).ToList());
                        soldiers.Add(new Commando(int.Parse(args[1]), args[2], args[3], double.Parse(args[4]), args[5], missions));
                    }
                    break;
                case "Spy":
                    soldiers.Add(new Spy(int.Parse(args[1]), args[2], args[3], int.Parse(args[4])));
                    break;
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }

    private static IList<IMission> ExtractMissions(List<string> args)
    {
        IList<IMission> missions = new List<IMission>();
        for (int i = 0; i < args.Count / 2; i++)
        {
            if (args[i * 2 + 1] == "inProgress" || args[i * 2 + 1] == "Finished")
            {
                missions.Add(new Mission(args[i * 2], args[i * 2 + 1]));
            }
        }

        return missions;
    }

    private static IList<IRepair> ExtractRepairs(List<string> args)
    {
        IList<IRepair> repairs = new List<IRepair>();
        for (int i = 0; i < args.Count / 2; i++)
        {
            repairs.Add(new Repair(args[i * 2], args[i * 2 + 1]));
        }

        return repairs;
    }

    private static IList<ISoldier> ExtractPrivets(List<string> args, IList<ISoldier> soldiers)
    {
        IList<ISoldier> privates = new List<ISoldier>();
        foreach (var id in args)
        {
           privates.Add(soldiers.First(s => s.Id == int.Parse(id)));
        }

        return privates;
    }
}
