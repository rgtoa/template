using System;
using System.Collections.Generic;

namespace ASP.NETCore_Exercise10.Models;

public partial class Aircraft
{
    public int Id { get; set; }

    public string? ImageUrl { get; set; }

    public string? ProductNumber { get; set; }

    public string Name { get; set; } = null!;

    public string? Model { get; set; }

    public string? Description { get; set; }

    public int? PaxMaxSeating { get; set; }

    public int? TypicalSeating { get; set; }

    public string? CargoD3capacity { get; set; }

    public int? MaxPalletNumber { get; set; }

    public string? WaterVolume { get; set; }

    public string? PerformanceRange { get; set; }

    public string? Mmo { get; set; }

    public string? MaxRampWeight { get; set; }

    public string? MaxTakeOffWeight { get; set; }

    public string? MaxLandingWeight { get; set; }

    public string? MaxFuelCapacity { get; set; }

    public string? OverallLength { get; set; }

    public string? CabinLength { get; set; }

    public string? FuselageWidth { get; set; }

    public string? MaxCabinWidth { get; set; }

    public string? WingSpan { get; set; }

    public string? Height { get; set; }

    public string? Track { get; set; }

    public string? Wheelbase { get; set; }
}
