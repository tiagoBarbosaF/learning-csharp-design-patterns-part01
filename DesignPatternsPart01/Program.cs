using DesignPatternsPart01.Classes.Invoices;
using DesignPatternsPart01.Classes.Invoices.Builders;

namespace DesignPatternsPart01;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = new InvoiceBuilder();
        var itemBuilder = new InvoiceItemBuilder();

        builder
            .ForCompany("Test")
            .WithCnpj("111111")
            .With(itemBuilder.ItemName("item1").ItemValue(100).Build())
            .With(itemBuilder.ItemName("item2").ItemValue(200).Build())
            .CurrentDate(new DateTime(2023,10,10))
            .WithObservations("test test");

        var invoice = builder.Build();
        
        Console.WriteLine(invoice);
        Console.WriteLine(invoice.GrossValue);
        Console.WriteLine(invoice.Taxes);
    }
}