namespace DesignPatternsPart01.Classes;

public class Account
{
    public string Holder { get; private set; }
    public double Balance { get; private set; }

    public Account(string holder, double balance)
    {
        Holder = holder;
        Balance = balance;
    }

    public void Deposit(double value) => Balance += value;
}