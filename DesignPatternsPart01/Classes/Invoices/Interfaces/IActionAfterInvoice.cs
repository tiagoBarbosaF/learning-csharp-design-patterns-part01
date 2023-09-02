namespace DesignPatternsPart01.Classes.Invoices.Interfaces;

public interface IActionAfterInvoice
{
    void Execute(Invoice invoice);
}