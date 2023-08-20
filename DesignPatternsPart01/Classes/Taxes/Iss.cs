namespace DesignPatternsPart01.Classes.Taxes;

public class Iss : Tax
{
    public Iss(Tax tax) : base(tax)
    {
    }

    public Iss() : base()
    {
    }

    public override double Calculate(Budget budget) => budget.Value * 0.06 + CalculateOtherTax(budget);
}