using System.Collections.Generic;
using System.Linq;

public class AddRemoveCollection<T> : IAddRemoveCollection<T>
{
    private IList<T> data;

    public AddRemoveCollection()
    {
        this.data = new List<T>();
    }

    public int Add(T element)
    {
        this.data.Insert(0, element);
        return 0;
    }

    public T Remove()
    {
        var rem = this.data.LastOrDefault();
        this.data.RemoveAt(this.data.Count - 1);
        return rem;
    }
}
