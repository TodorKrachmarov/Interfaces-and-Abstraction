using System.Collections.Generic;
using System.Text;

public class Commando : Private, ICommando
{
    public Commando(int id, string firstName, string lastName, double salary, string corps, IList<IMission> missions) 
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
        this.Missions = missions;
    }

    public string Corps { get; private set; }

    public IList<IMission> Missions { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Missions:");
        foreach (var mission in this.Missions)
        {
            sb.AppendLine("  " + mission.ToString());
        }

        return sb.ToString().Trim();
    }
}
