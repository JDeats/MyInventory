using System;

namespace Domain;

public class FerriteBead : ElectronicComponent
{
    public required double Impedance { get; set; }
    public required double MaxDcCurrent { get; set; }
    public required double MaxDcResistance { get; set; }

    public FerriteBead()
    {
        Name = "Ferrite Bead";
    }
}
