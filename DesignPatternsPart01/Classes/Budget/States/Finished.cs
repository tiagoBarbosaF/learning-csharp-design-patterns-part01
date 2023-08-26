using DesignPatternsPart01.Classes.Budget.Interfaces;

namespace DesignPatternsPart01.Classes.Budget.States;

public class Finished : IStateOfBudget
{
    public void ApplyExtraDiscount(Budget budget)
    {
        throw new Exception("Finished budgets not receive extra discount.");
    }

    public void ApprovedState(Budget budget)
    {
        throw new Exception("The budget is finalized.");
    }

    public void DisapprovedState(Budget budget)
    {
        throw new Exception("The budget is finalized.");
    }

    public void FinishedState(Budget budget)
    {
        throw new Exception("The budget is finalized.");
    }
}