namespace DesignPatternsPart01.Classes;

public class Item
{
    public String Name { get; private set; }
    public double Value { get; private set; }

    public Item(string name, double value)
    {
        Name = name;
        Value = value;
    }
}