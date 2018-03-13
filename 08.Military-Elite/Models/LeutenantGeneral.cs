using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(int id, string firstName, string lastName, double salary, IList<ISoldier> privates) 
        : base(id, firstName, lastName, salary)
    {
        this.Privates = privates;
    }

    public IList<ISoldier> Privates { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");
        foreach (var Private in this.Privates)
        {
            sb.AppendLine("  " + Private.ToString());
        }

        return sb.ToString().Trim();
    }
}
