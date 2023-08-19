using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class DiscountByMoreFiveHundred : IDiscount
{
    public IDiscount Next { get; set; }

    public double Discounting(Budget budget)
    {
        if (budget.Value > 500)
            return budget.Value * 0.07;

        return Next.Discounting(budget);
    }
}