namespace DesignPatternsPart01.Classes;

public abstract class Tax
{
    private Tax OtherTax { get; set; }

    protected Tax(Tax otherTax)
    {
        OtherTax = otherTax;
    }

    protected Tax()
    {
        OtherTax = null;
    }


    protected double CalculateOtherTax(Budget budget) => OtherTax == null ? 0 : OtherTax.Calculate(budget);
    public abstract double Calculate(Budget budget);
}