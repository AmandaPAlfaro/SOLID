﻿using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee();
            
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary ${ emp.Salary }/hour.");
            Console.ReadLine();
        }
    }
}
