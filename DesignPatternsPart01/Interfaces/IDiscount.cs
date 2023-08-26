using DesignPatternsPart01.Classes;
using DesignPatternsPart01.Classes.Budget;

namespace DesignPatternsPart01.Interfaces;

public interface IDiscount
{
    double Discounting(Budget budget);

    IDiscount Next { get; set; }
}