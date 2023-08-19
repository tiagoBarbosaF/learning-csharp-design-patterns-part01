using DesignPatternsPart01.Classes.Templates;

namespace DesignPatternsPart01.Classes;

public class ComplexReport : TemplateReport
{
    protected override void Header() => Console.WriteLine("MyBank - Rua 01 - 1111 - +55 85 1111.2222");

    protected override void Footer() => Console.WriteLine($"mybank@email.com - {DateTime.Now:D}");

    protected override void Body(IEnumerable<Account> accounts)
    {
        foreach (var account in accounts)
            Console.WriteLine(
                $"Holder: {account.Holder} - Agency: {account.Agency} - Number: {account.Number} - Balance: {account.Balance}");
    }
}