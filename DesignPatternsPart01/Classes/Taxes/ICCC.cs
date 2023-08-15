namespace DesignPatternsPart01.Classes.Taxes;

public class ICCC : Tax
{
    public double Calculate(Budget budget)
    {
        if (budget.Value < 1000)
            return budget.Value * 0.05;
        
        if (budget.Value is >= 1000 and <= 3000)
            return budget.Value * 0.07;
        
        return budget.Value * 0.08 + 30;
    }

    public void PerformsCalculation(string type, Budget budget, Tax tax)
    {
        Console.WriteLine($"{type}: {tax.Calculate(budget):F}");
    }
}