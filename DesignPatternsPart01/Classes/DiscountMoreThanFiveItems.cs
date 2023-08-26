using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class DiscountMoreThanFiveItems : IDiscount
{
    public IDiscount Next { get; set; }

    public double Discounting(Budget.Budget budget)
    {
        if (budget.Items.Count > 5)
            return budget.Value * 0.1;
        
        return Next.Discounting(budget);
    }
}