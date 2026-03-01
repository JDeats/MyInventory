namespace Domain;

public abstract class Item
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required int Quantity { get; set; }
    public required string Vendor { get; set; }
    public string? VendorPartNumber { get; set; }
    public string? Manufacturer { get; set; }
    public string? ManufacturerPartNumber { get; set; }
    public string? Details { get; set; }
}
