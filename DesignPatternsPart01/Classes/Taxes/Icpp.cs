using DesignPatternsPart01.Classes.Templates;

namespace DesignPatternsPart01.Classes.Taxes;

public class Icpp : TemplateConditionalTax
{
    public Icpp(Tax tax) : base(tax)
    {
    }

    public Icpp() : base()
    {
    }

    protected override bool MustUseMaxTax(Budget.Budget budget) => budget.Value >= 500;
    protected override double MaxTax(Budget.Budget budget) => budget.Value * 0.07;
    protected override double MinimalTax(Budget.Budget budget) => budget.Value * 0.05;
}