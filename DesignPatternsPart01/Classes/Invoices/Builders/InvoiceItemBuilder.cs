namespace DesignPatternsPart01.Classes.Invoices.Builders;

public class InvoiceItemBuilder
{
    private string Name { get; set; }
    private double Value { get; set; }

    public InvoiceItem Build()
    {
        return new InvoiceItem(Name, Value);
    }

    public InvoiceItemBuilder ItemName(string name)
    {
        Name = name;
        return this;
    }

    public InvoiceItemBuilder ItemValue(double value)
    {
        Value = value;
        return this;
    }
}