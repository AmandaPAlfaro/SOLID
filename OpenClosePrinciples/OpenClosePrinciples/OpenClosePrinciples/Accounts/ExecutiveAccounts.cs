namespace OpenClosePrinciples
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{person.FirstName}.{person.LastName}@acme.com";

            output.IsManager = true;
            output.IsExecutive= true;

            return output;
        }
    }
}
