public class Citizen : IResident, IPerson
{
    private string name;

    public Citizen(string name, string country, int age)
    {
        this.name = name;
        this.Country = country;
        this.Age = age;
    }

    string IResident.Name { get { return this.name; } }

    public int Age { get; private set; }

    string IPerson.GetName()
    {
        return this.name;
    }

    public string Country { get; private set; }

    string IPerson.Name { get { return this.name; } }

    string IResident.GetName()
    {
        return "Mr/Ms/Mrs " + this.name;
    }
}
