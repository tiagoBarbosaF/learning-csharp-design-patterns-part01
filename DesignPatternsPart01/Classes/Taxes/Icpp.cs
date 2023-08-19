using DesignPatternsPart01.Classes.Templates;

namespace DesignPatternsPart01.Classes.Taxes;

public class Icpp : TemplateConditionalTax
{
    protected override bool MustUseMaxTax(Budget budget) => budget.Value >= 500;
    protected override double MaxTax(Budget budget) => budget.Value * 0.07;
    protected override double MinimalTax(Budget budget) => budget.Value * 0.05;
}