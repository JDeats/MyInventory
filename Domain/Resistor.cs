using System;

namespace Domain;

public class Resistor : ElectronicComponent
{
    public required string Resistance { get; set; }
    public required string PowerRating { get; set; }

    public Resistor()
    {
        Name = "Resistor";
    }
}
