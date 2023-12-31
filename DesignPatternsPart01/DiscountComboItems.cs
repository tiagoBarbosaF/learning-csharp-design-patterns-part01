﻿using DesignPatternsPart01.Classes;
using DesignPatternsPart01.Classes.Budget;
using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01;

public class DiscountComboItems : IDiscount
{
    public IDiscount Next { get; set; }

    public bool Exists(string itemName, Budget budget)
    {
        foreach (var item in budget.Items)
            if (item.Name.Equals(itemName))
                return true;

        return false;
    }

    public double Discounting(Budget budget)
    {
        if (Exists("PENCIL", budget) && Exists("PEN", budget))
            return budget.Value * 0.05;

        return Next.Discounting(budget);
    }
}