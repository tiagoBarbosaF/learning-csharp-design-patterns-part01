using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01;

internal class Program
{
    public static void Main(string[] args)
    {
        var account1 = new Account("Tiago", 1000, "1111", "2222-X");
        var account2 = new Account("Peter", 2000, "1111", "3333-X");
        IList<Account> accounts = new List<Account>();
        accounts.Add(account1);
        accounts.Add(account2);
        var simpleReport = new SimpleReport();
        var complexReport = new ComplexReport();
        
        simpleReport.Print(accounts);
        Console.WriteLine("---");
        complexReport.Print(accounts);
    }
}