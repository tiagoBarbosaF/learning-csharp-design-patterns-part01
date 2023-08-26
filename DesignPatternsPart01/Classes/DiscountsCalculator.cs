namespace DesignPatternsPart01.Classes;

public class DiscountsCalculator
{
    public double Calculate(Budget.Budget budget)
    {
        var d1 = new DiscountMoreThanFiveItems();
        var d2 = new DiscountByMoreFiveHundred();
        var d3 = new DiscountComboItems();
        var d4 = new NoDiscount();

        d1.Next = d2;
        d2.Next = d3;
        d3.Next = d4;

        return d1.Discounting(budget);
    }
}