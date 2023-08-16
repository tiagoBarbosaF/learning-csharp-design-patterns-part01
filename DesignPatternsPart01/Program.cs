using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01;

internal class Program
{
    public static void Main(string[] args)
    {
        var calculator = new DiscountsCalculator();

        var budget = new Budget(500);
        budget.AddItem(new Item("PEN", 250));
        budget.AddItem(new Item("PENCIL", 250));
        budget.AddItem(new Item("FRIDGE", 250));
        budget.AddItem(new Item("STOVE", 250));
        budget.AddItem(new Item("MICROWAVES", 250));
        budget.AddItem(new Item("XBOX", 250));

        var discount = calculator.Calculate(budget);
        Console.WriteLine(discount);
    }
}