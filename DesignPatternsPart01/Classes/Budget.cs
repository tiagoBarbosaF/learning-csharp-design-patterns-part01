﻿namespace DesignPatternsPart01;

public class Budget
{
    public double Value { get; private set; }

    public Budget(double value)
    {
        Value = value;
    }
}