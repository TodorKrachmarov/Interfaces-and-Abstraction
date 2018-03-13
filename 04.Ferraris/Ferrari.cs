public class Ferrari : ICar
{
    private const string model = "488-Spider";

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Driver { get; private set; }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        //<model>/<brakes>/<gas pedal>/<driver's name>
        return $"{model}/{this.UseBrakes()}/{this.PushTheGasPedal()}/{this.Driver}";
    }
}
