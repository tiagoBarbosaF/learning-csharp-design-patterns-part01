using DesignPatternsPart01.Classes.Templates;

namespace DesignPatternsPart01.Classes.Taxes;

public class Ihit : TemplateConditionalTax
{
    protected override bool MustUseMaxTax(Budget.Budget budget) =>
        budget.Items.GroupBy(item => item.Name).Any(group => group.Count() == 2);

    protected override double MaxTax(Budget.Budget budget) => budget.Value * 0.13 + 100;

    protected override double MinimalTax(Budget.Budget budget) =>
        budget.Value * 0.01 * budget.Items.Count;
}