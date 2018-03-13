using System;

public class Program
{
    static void Main(string[] args)
    {
        IPhone phone = new Phone("smartphone");
        string[] numbers = Console.ReadLine().Split();

        foreach (var number in numbers)
        {
            Console.WriteLine(phone.MakeCall(number));
        }

        string[] urls = Console.ReadLine().Split();

        foreach (var url in urls)
        {
            Console.WriteLine(phone.Browsing(url));
        }
    }
}
