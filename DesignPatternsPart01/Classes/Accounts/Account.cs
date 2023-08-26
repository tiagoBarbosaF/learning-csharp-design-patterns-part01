using DesignPatternsPart01.Classes.Accounts.Interfaces;

namespace DesignPatternsPart01.Classes.Accounts;

public class Account
{
    public string Holder { get; private set; }
    public double Balance { get; private set; }
    public string Agency { get; set; }
    public string Number { get; set; }
    public DateTime OpeningDate { get; private set; }
    private IAccountState _accountState;
    public string CurrentState;

    public Account(string holder, double balance, string agency, string number, DateTime openingDate)
    {
        Holder = holder;
        Balance = balance;
        Agency = agency;
        Number = number;
        OpeningDate = openingDate;
        if (Balance >= 0)
        {
            _accountState = new Positive();
            CurrentState = "Positive";
        }
        else
        {
            _accountState = new Negative();
            CurrentState = "Negative";
        }
    }

    public void Withdraw(double value)
    {
        _accountState.Withdraw(this, value);
        ChangeState(_accountState);
    }

    public void Deposit(double value)
    {
        _accountState.Deposit(this, value);
        ChangeState(_accountState);
    }

    private void ChangeState(IAccountState newState)
    {
        _accountState = newState;
        CurrentState = _accountState.GetType().Name;
    }

    private class Positive : IAccountState
    {
        public void Withdraw(Account account, double value)
        {
            account.Balance -= value;

            if (account.Balance < 0) account._accountState = new Negative();
        }

        public void Deposit(Account account, double value) => account.Balance += value * 0.98;
    }

    private class Negative : IAccountState
    {
        public void Withdraw(Account account, double value) =>
            throw new Exception("Your account is negative, it's not permitted withdraws.");

        public void Deposit(Account account, double value)
        {
            account.Balance += value * 0.95;

            if (account.Balance > 0) account._accountState = new Positive();
        }
    }
}