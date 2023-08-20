namespace DesignPatternsPart01.Classes.Templates;

public abstract class TemplateConditionalTax : Tax
{
    public TemplateConditionalTax(Tax tax) : base(tax)
    {
    }

    public TemplateConditionalTax() : base()
    {
    }

    public override double Calculate(Budget budget) => MustUseMaxTax(budget) ? MaxTax(budget) + CalculateOtherTax(budget) : MinimalTax(budget);

    protected abstract bool MustUseMaxTax(Budget budget);
    protected abstract double MaxTax(Budget budget);
    protected abstract double MinimalTax(Budget budget);
}