using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes.Templates;

public abstract class TemplateConditionalTax : ITax
{
    public double Calculate(Budget budget) => MustUseMaxTax(budget) ? MaxTax(budget) : MinimalTax(budget);

    protected abstract bool MustUseMaxTax(Budget budget);
    protected abstract double MaxTax(Budget budget);
    protected abstract double MinimalTax(Budget budget);
}