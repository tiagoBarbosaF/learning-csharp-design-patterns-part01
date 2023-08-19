using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01.Interfaces;

public interface ITax
{
    double Calculate(Budget budget);
}