using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class DiscountMoreThanFiveItems : Discount
{
    public Discount Next { get; set; }

    public double Discounting(Budget budget)
    {
        if (budget.Items.Count > 5)
            return budget.Value * 0.1;
        
        return Next.Discounting(budget);
    }
}