namespace DesignPatternsPart01.Classes.Taxes;

public class ICMS : Tax
{
    public double Calculate(Budget budget) => budget.Value * 0.1;
    
    public void PerformsCalculation(string type, Budget budget, Tax tax)
    {
        Console.WriteLine($"{type}: {tax.Calculate(budget):F}");
    }
}