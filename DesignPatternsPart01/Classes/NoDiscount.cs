using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class NoDiscount : IDiscount
{
    public IDiscount Next { get; set; }
    public double Discounting(Budget budget) => 0;
}