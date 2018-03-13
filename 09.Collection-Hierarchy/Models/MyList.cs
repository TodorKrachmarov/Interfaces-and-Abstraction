using System.Collections.Generic;
using System.Linq;

public class MyList<T> : IMyList<T>
{
    private IList<T> data;

    public MyList()
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
        var rem = this.data.FirstOrDefault();
        this.data.RemoveAt(0);
        return rem;
    }

    public int Used { get { return this.data.Count; } }
}
