namespace DesignPatternsPart01.Classes.Taxes;

public class TaxVeryHigh : Tax
{
    public TaxVeryHigh(Tax tax) : base(tax)
    {
    }

    public TaxVeryHigh() : base()
    {
    }

    public override double Calculate(Budget.Budget budget)
    {
        return budget.Value * 0.20 + CalculateOtherTax(budget);
    }
}