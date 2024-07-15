namespace WorldCupSimulator.Util;
public record class DataLogs
{
    public string Description { get; set; } = null!;
    public Team TeamOne { get; set; } = null!;
    public Team TeamTwo { get; set; } = null!;
    public Team Winner { get; set; } = null!;
}
