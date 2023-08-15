using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class Moderate : Investment
{
    private Random _random;

    public Moderate()
    {
        _random = new Random();
    }

    public double Calculate(Account account)
    {
        if (_random.Next(2) == 0)
            return account.Balance * 0.025;
        else
            return account.Balance * 0.007;
    }
}