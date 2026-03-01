using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Capacitor> Capacitors { get; set; }
    public required DbSet<FerriteBead> FerriteBeads { get; set; }
    public required DbSet<Resistor> Resistors { get; set; }
    public required DbSet<GenericElectronicComponent> GenericElectronicComponents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Item>().UseTptMappingStrategy();
        modelBuilder.Entity<ElectronicComponent>();
    }
}
