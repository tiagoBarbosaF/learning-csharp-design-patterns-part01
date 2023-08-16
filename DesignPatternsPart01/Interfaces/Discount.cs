using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01.Interfaces;

public interface Discount
{
    double Discounting(Budget budget);

    Discount Next { get; set; }
}