using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class MakeInvestment
{
    public void Investment(Account account, Investment investment)
    {
        var result = investment.Calculate(account);

        account.Deposit(result * 0.75);

        Console.WriteLine($"Investment: {investment.GetType().Name}, New balance: {account.Balance:F}");
    }
}