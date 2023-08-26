namespace DesignPatternsPart01.Classes.Accounts.Interfaces;

public interface IAccountState
{
    void Withdraw(Account account, double value);

    void Deposit(Account account, double value);
}