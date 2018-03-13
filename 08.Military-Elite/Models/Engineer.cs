using System.Collections.Generic;
using System.Text;

public class Engineer : Private, IEngineer
{
    public Engineer(int id, string firstName, string lastName, double salary, string corps, IList<IRepair> repairs) 
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
        this.Repairs = repairs;
    }

    public string Corps { get; private set; }

    public IList<IRepair> Repairs { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Repairs:");
        foreach (var repair in this.Repairs)
        {
            sb.AppendLine("  " + repair.ToString());
        }

        return sb.ToString().Trim();
    }
}
