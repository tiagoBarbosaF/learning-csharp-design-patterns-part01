namespace DesignPatternsPart01;

public interface Tax
{
    double Calculate(Budget budget);

    void PerformsCalculation(string type, Budget budget, Tax tax);
}