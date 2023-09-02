using DesignPatternsPart01.Classes.Invoices.Interfaces;

namespace DesignPatternsPart01.Classes.Invoices;

public class InvoiceDao : IActionAfterInvoice
{
    public void Execute(Invoice invoice)
    {
        Console.WriteLine("saving in database...");
    }
}