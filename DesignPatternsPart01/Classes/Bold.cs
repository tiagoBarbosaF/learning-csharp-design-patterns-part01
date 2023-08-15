using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class Bold : Investment
{
    private Random _random;

    public Bold()
    {
        _random = new Random();
    }

    public double Calculate(Account account)
    {
        var chance = _random.Next(10);

        return chance switch
        {
            >= 0 and <= 1 => account.Balance * 0.5,
            >= 2 and <= 4 => account.Balance * 0.3,
            _ => account.Balance * 0.006
        };
    }
}