using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel> {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new PersonModel { FirstName = "Sue", LastName = "Storm", TypeOfEmployee = EmployeeType.Manager },
                new PersonModel { FirstName = "Nancy", LastName = "Roman" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountsProcesson = new Accounts();

            foreach (var person in applicants) 
            {
                employees.Add(accountsProcesson.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName}{emp.LastName}: {emp.EmailAdress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive }");
            }
            Console.ReadLine();
        }
    }
}
