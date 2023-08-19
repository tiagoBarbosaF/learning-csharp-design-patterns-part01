using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01.Interfaces;

public interface IDiscount
{
    double Discounting(Budget budget);

    IDiscount Next { get; set; }
}