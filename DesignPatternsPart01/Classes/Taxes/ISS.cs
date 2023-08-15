namespace DesignPatternsPart01.Classes.Taxes;

public class ISS : Tax
{
    public double Calculate(Budget budget) => budget.Value * 0.06;
    
    public void PerformsCalculation(string type, Budget budget, Tax tax)
    {
        Console.WriteLine($"{type}: {tax.Calculate(budget):F}");
    }
}