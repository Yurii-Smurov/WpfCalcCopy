﻿using WpfApp1.Interfaces;

namespace ConsoleCalculator.Core.Operations
{
    public class SubtractOperation : IOperation
    {
        public string GetOperator() => "-"; 
        public int GetPriority() => 1;
        public double Execute(double left, double right) => left - right;
    }
}
