using DesignPatternsPart01.Classes.Invoices.Interfaces;

namespace DesignPatternsPart01.Classes.Invoices;

public class SendingSms : IActionAfterInvoice
{
    public void Execute(Invoice invoice)
    {
        Console.WriteLine("sending by sms...");
    }
}