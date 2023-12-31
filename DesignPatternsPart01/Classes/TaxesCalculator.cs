﻿using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class TaxesCalculator
{
    public void PerformsCalculation(string type, Budget.Budget budget, Tax tax)
    {
        Console.WriteLine($"{type}: {tax.Calculate(budget):F}");
    }
}