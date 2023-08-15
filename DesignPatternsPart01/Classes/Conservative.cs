using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class Conservative : Investment
{
    public double Calculate(Account account)
    {
        return account.Balance * 0.008;
    }
}