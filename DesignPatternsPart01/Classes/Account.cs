using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01.Classes;

public class Account
{
    public string Holder { get; private set; }
    public double Balance { get; private set; }
    public string Agency { get; set; }
    public string Number { get; set; }

    public Account(string holder, double balance, string agency, string number)
    {
        Holder = holder;
        Balance = balance;
        Agency = agency;
        Number = number;
    }

    public void Deposit(double value) => Balance += value;
}