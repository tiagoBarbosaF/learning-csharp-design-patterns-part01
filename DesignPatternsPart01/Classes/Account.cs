namespace DesignPatternsPart01.Classes;

public class Account
{
    public double Balance { get; private set; }

    public void Deposit(double value) => Balance += value;
}