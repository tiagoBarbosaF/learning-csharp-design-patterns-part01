using DesignPatternsPart01.Classes.Invoices.Interfaces;

namespace DesignPatternsPart01.Classes.Invoices;

public class SendingEmail : IActionAfterInvoice
{
    public void Execute(Invoice invoice)
    {
        Console.WriteLine("sending email...");
    }
}