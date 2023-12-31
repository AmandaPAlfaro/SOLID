﻿namespace OpenClosePrinciples
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com";

            output.IsManager = true;
            
            return output;
        }
    }
}
