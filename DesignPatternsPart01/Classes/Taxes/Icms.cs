using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes.Taxes;

public class Icms : ITax
{
    public double Calculate(Budget budget) => budget.Value * 0.1;
    
    public void PerformsCalculation(string type, Budget budget, ITax tax)
    {
        Console.WriteLine($"{type}: {tax.Calculate(budget):F}");
    }
}