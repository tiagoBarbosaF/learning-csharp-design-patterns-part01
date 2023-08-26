using DesignPatternsPart01.Classes;
using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01.Interfaces;

public interface IInvestment
{
    double Calculate(Account account);
}