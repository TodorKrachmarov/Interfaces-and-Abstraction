using System.Collections.Generic;

public class AddCollection<T> : IAddCollection<T>
{
    private IList<T> data;

    public AddCollection()
    {
        this.data = new List<T>();
    }

    public int Add(T element)
    {
        int index = this.data.Count;
        this.data.Add(element);
        return index;
    }
}
