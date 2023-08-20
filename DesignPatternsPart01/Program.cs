using DesignPatternsPart01.Classes;
using DesignPatternsPart01.Classes.Taxes;

namespace DesignPatternsPart01;

internal class Program
{
    public static void Main(string[] args)
    {
        var accounts = new List<Account>
        {
            new Account("Holder 1", 50, "111", "111-X", new DateTime(2022, 7, 1)),
            new Account("Holder 2", 200_000, "211", "211-X", new DateTime(2023, 7, 15)),
            new Account("Holder 3", 700_000, "111", "111-X", new DateTime(2022, 7, 25)),
            new Account("Holder 4", 150, "131", "131-X", new DateTime(2023, 8, 5)),
            new Account("Holder 5", 1_000_000, "113", "113-X", new DateTime(2023, 8, 10))
        };

        var compositeFilter = new CompositeFilter();
        compositeFilter.AddFilter(new BalanceFilter(100, 500_000));
        compositeFilter.AddFilter(new OpeningDateFilter(DateTime.Now));

        var filteredAccounts = compositeFilter.FilterAccounts(accounts);

        foreach (var account in filteredAccounts)
        {
            Console.WriteLine(
                $"Holder: {account.Holder} - Balance: {account.Balance} - Opening Date: {account.OpeningDate}");
        }
    }
}