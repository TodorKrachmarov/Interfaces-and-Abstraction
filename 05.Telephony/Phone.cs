using System;
using System.Linq;

public class Phone : IPhone
{
    public Phone(string model)
    {
        this.Model = model;
    }

    public string Model { get; private set; }

    public string Browsing(string url)
    {
        if (!url.Where(x => Char.IsDigit(x)).Any())
        {
            return $"Browsing: {url}!";
            
        }

        return "Invalid URL!";
    }

    public string MakeCall(string number)
    {
        if (number.All(c => char.IsDigit(c)))
        {
            return $"Calling... {number}";
        }

        return "Invalid number!";
    }
}
