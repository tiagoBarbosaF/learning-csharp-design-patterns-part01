using DesignPatternsPart01.Classes.Budget.Interfaces;
using DesignPatternsPart01.Classes.Budget.States;

namespace DesignPatternsPart01.Classes.Budget;

public class Budget
{
    public double Value { get; set; }
    public List<Item> Items { get; private set; }
    public IStateOfBudget CurrentState { get; set; }

    public Budget(double value)
    {
        Value = value;
        Items = new List<Item>();
        CurrentState = new OnApproval();
    }

    public void AddItem(Item item) => Items.Add(item);

    public void ApplyExtraDiscount() => CurrentState.ApplyExtraDiscount(this);

    public void Approved() => CurrentState.ApprovedState(this);

    public void Disapproved() => CurrentState.DisapprovedState(this);

    public void Finished() => CurrentState.FinishedState(this);
}