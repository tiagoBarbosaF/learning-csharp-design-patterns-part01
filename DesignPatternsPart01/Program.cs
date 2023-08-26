using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01;

internal class Program
{
    public static void Main(string[] args)
    {
        var account = new Account("Tiago", 0, "111", "111-x", new DateTime(2020, 4, 4));
        Console.WriteLine($"Initial Balance: {account.Balance} - State Account: {account.CurrentState}");
        account.Withdraw(50);
        
        Console.WriteLine($"After withdraw: {account.Balance} - State Account: {account.CurrentState}");
        
        // account.Withdraw(100);
        //
        // Console.WriteLine($"After withdraw again: {account.Balance} - State Account: {account.CurrentState}");
        
        account.Deposit(1000);
        
        Console.WriteLine($"After deposit: {account.Balance} - State Account: {account.CurrentState}");
    }
}