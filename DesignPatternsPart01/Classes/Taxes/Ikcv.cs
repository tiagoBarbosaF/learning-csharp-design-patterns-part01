﻿using DesignPatternsPart01.Classes.Templates;

namespace DesignPatternsPart01.Classes.Taxes;

public class Ikcv : TemplateConditionalTax
{
    public Ikcv(Tax otherTax) : base(otherTax)
    {
    }

    public Ikcv() : base()
    {
    }

    protected override bool MustUseMaxTax(Budget.Budget budget) => budget.Value > 500 && ItemGreaterThan100(budget);
    private static bool ItemGreaterThan100(Budget.Budget budget) => budget.Items.Any(_ => budget.Value > 100);
    protected override double MaxTax(Budget.Budget budget) => budget.Value * 0.1;
    protected override double MinimalTax(Budget.Budget budget) => budget.Value * 0.06;
}