namespace DesignPatternsPart01.Classes.Budget.Interfaces;

public interface IStateOfBudget
{
    void ApplyExtraDiscount(Budget budget);

    void ApprovedState(Budget budget);

    void DisapprovedState(Budget budget);

    void FinishedState(Budget budget);
}