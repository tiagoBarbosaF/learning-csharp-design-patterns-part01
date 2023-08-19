using DesignPatternsPart01.Classes.Templates;

namespace DesignPatternsPart01.Classes;

public class SimpleReport : TemplateReport
{
    protected override void Header() => Console.WriteLine("MyBank");

    protected override void Footer() => Console.WriteLine($"+55 85 1111.3333");

    protected override void Body(IEnumerable<Account> accounts)
    {
        foreach (var account in accounts) Console.WriteLine($"Holder: {account.Holder} - Balance: {account.Balance}");
    }
}   