namespace Domain;

public abstract class ElectronicComponent : Item
{
    public required string MountingStyle { get; set; }
    public string? Size { get; set; }
    public double? Tolerance { get; set; }
    public string? LinkToDatasheet { get; set; }
}
