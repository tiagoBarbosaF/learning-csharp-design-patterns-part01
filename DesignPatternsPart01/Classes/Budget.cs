namespace DesignPatternsPart01.Classes;

public class Budget
{
    public double Value { get; private set; }
    public List<Item> Items { get; private set; }

    public Budget(double value)
    {
        Value = value;
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }
}