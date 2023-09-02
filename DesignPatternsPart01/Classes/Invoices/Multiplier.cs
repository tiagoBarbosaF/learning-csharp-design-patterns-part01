using DesignPatternsPart01.Classes.Invoices.Interfaces;

namespace DesignPatternsPart01.Classes.Invoices;

public class Multiplier : IActionAfterInvoice
{
    public double Factor { get; private set; }

    public Multiplier(double factor)
    {
        Factor = factor;
    }
    
    public void Execute(Invoice invoice)
    {
        var result = invoice.GrossValue * Factor;
        
        Console.WriteLine(result);
    }
}