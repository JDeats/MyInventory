namespace Domain;

public class Capacitor : ElectronicComponent
{
    public required double Capacitance { get; set; }
    public required double Voltage { get; set; }

    public Capacitor()
    {
        Name = "Capacitor";
    }
}
