using DesignPatternsPart01.Classes.Budget.Interfaces;

namespace DesignPatternsPart01.Classes.Budget.States;

public class Disapproved : IStateOfBudget
{
    public void ApplyExtraDiscount(Budget budget)
    {
        throw new Exception("Disapproved budgets not receive extra discount.");
    }

    public void ApprovedState(Budget budget)
    {
        throw new Exception("The budget has already been disapproved.");
    }

    public void DisapprovedState(Budget budget)
    {
        throw new Exception("The budget has already been disapproved.");
    }

    public void FinishedState(Budget budget)
    {
        budget.CurrentState = new Finished();
    }
}