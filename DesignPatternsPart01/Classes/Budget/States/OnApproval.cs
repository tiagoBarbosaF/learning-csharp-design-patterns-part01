using DesignPatternsPart01.Classes.Budget.Interfaces;

namespace DesignPatternsPart01.Classes.Budget.States;

public class OnApproval : IStateOfBudget
{
    private bool discountApplied = false;

    public void ApplyExtraDiscount(Budget budget)
    {
        if (!discountApplied)
        {
            budget.Value -= budget.Value * 0.05;
            discountApplied = true;
        }
        else
            throw new Exception("Discount already applied.");
    }

    public void ApprovedState(Budget budget)
    {
        budget.CurrentState = new Approved();
    }

    public void DisapprovedState(Budget budget)
    {
        budget.CurrentState = new Disapproved();
    }

    public void FinishedState(Budget budget)
    {
        throw new Exception("Budgets under approval are not finalized directly.");
    }
}