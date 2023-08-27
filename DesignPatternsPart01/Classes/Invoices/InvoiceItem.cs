namespace DesignPatternsPart01.Classes.Invoices;

public class InvoiceItem
{
    public string Name { get; private set; }
    public double Value { get; private set; }

    public InvoiceItem(string name, double value)
    {
        Name = name;
        Value = value;
    }
}