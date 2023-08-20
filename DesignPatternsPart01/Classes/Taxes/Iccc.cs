namespace DesignPatternsPart01.Classes.Taxes;

public class Iccc : Tax
{
    public Iccc(Tax tax) : base(tax)
    {
    }

    public Iccc() : base()
    {
    }

    public override double Calculate(Budget budget)
    {
        return budget.Value switch
        {
            < 1000 => budget.Value * 0.05,
            >= 1000 and <= 3000 => budget.Value * 0.07,
            _ => budget.Value * 0.08 + 30
        };
    }
}