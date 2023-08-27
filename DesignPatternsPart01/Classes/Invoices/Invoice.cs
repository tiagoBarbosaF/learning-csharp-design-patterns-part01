namespace DesignPatternsPart01.Classes.Invoices;

public class Invoice
{
    public string CorporateName { get; set; }
    public string Cnpj { get; set; }
    public DateTime DateOfIssue { get; set; }
    public double GrossValue { get; set; }
    public double Taxes { get; set; }
    public IList<InvoiceItem> Items { get; set; }
    public string Observations { get; set; }

    public Invoice(string corporateName, string cnpj, DateTime dateOfIssue, double grossValue, double taxes,
        IList<InvoiceItem> items, string observations)
    {
        CorporateName = corporateName;
        Cnpj = cnpj;
        DateOfIssue = dateOfIssue;
        GrossValue = grossValue;
        Taxes = taxes;
        Items = items;
        Observations = observations;
    }

    public override string ToString()
    {
        return
            $"corporate name: {CorporateName}, " +
            $"cnpj: {Cnpj}, " +
            $"Date of Issue: {DateOfIssue}, " +
            $"Gross value: {GrossValue}, " +
            $"Taxes: {Taxes}, " +
            $"Items: {string.Join(", ,",Items.Select(item => $"{item.Name}: {item.Value:C}"))}, " +
            $"Observations: {Observations}";
    }
}