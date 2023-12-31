﻿using System;

namespace LiskovSubstitutionPrinciple
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;  
        }

        public void GeneratePerformanceReview() 
        {
            Console.WriteLine("I am reviewing a direct report's performance.");
        }

        public void FireSomeone() 
        {
            Console.WriteLine("You're Fired");
        }
    }
}
