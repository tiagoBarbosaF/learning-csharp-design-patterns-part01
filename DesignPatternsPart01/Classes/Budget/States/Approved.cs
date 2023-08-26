using DesignPatternsPart01.Classes.Budget.Interfaces;

namespace DesignPatternsPart01.Classes.Budget.States;

public class Approved : IStateOfBudget
{
    private bool discountApplied = false;

    public void ApplyExtraDiscount(Budget budget)
    {
        if (!discountApplied)
        {
            budget.Value -= budget.Value * 0.02;
            discountApplied = true;
        }
        else
            throw new Exception("Discount already applied.");
    }

    public void ApprovedState(Budget budget)
    {
        throw new Exception("Budget is already under approval.");
    }

    public void DisapprovedState(Budget budget)
    {
        throw new Exception("Budget in approval, cannot be disapproved.");
    }

    public void FinishedState(Budget budget)
    {
        budget.CurrentState = new Finished();
    }
}