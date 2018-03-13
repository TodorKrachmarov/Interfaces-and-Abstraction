using System;

public class Program
{
    static void Main(string[] args)
    {
        IAddCollection<string> addCollection = new AddCollection<string>();
        IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
        IMyList<string> myList = new MyList<string>();

        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(addCollection.Add(input[i]) + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(addRemoveCollection.Add(input[i]) + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(myList.Add(input[i]) + " ");
        }
        Console.WriteLine();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.Write(addRemoveCollection.Remove() + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < num; i++)
        {
            Console.Write(myList.Remove() + " ");
        }
        Console.WriteLine();
    }
}
