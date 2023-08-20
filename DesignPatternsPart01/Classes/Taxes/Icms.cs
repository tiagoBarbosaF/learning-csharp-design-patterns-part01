using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes.Taxes;

public class Icms : Tax
{
    public Icms(Tax tax) : base(tax)
    {
    }

    public Icms() : base()
    {
    }

    public override double Calculate(Budget budget)
    {
        return budget.Value * 0.1 + CalculateOtherTax(budget);
    }
}