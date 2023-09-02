using DesignPatternsPart01.Classes.Invoices.Interfaces;

namespace DesignPatternsPart01.Classes.Invoices.Builders;

public class InvoiceBuilder
{
    private string CorporateName { get; set; }
    private string Cnpj { get; set; }
    private string Observations { get; set; }
    private DateTime Date { get; set; }
    private double _totalValue;
    private double _taxes;
    private readonly IList<InvoiceItem> _allItems = new List<InvoiceItem>();

    private readonly IList<IActionAfterInvoice> _allActionsToExecute = new List<IActionAfterInvoice>();

    public InvoiceBuilder(IList<IActionAfterInvoice> listActions)
    {
        Date = DateTime.Now;
        _allActionsToExecute = listActions;
    }

    public Invoice Build()
    {
        var invoice = new Invoice(CorporateName, Cnpj, Date, _totalValue, _taxes, _allItems, Observations);

        foreach (var action in _allActionsToExecute) action.Execute(invoice);

        return invoice;
    }

    public void AddAction(IActionAfterInvoice newAction) => _allActionsToExecute.Add(newAction);

    public InvoiceBuilder ForCompany(string corporateName)
    {
        CorporateName = corporateName;
        return this;
    }

    public InvoiceBuilder WithObservations(string observations)
    {
        Observations = observations;
        return this;
    }

    public InvoiceBuilder CurrentDate(DateTime date)
    {
        Date = date;
        return this;
    }

    public InvoiceBuilder WithCnpj(string cnpj)
    {
        Cnpj = cnpj;
        return this;
    }

    public InvoiceBuilder With(InvoiceItem item)
    {
        _allItems.Add(item);
        _totalValue += item.Value;
        _taxes += item.Value * 0.05;
        return this;
    }
}