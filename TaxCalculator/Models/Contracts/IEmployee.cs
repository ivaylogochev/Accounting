namespace TaxCalculator.Models.Contracts
{
    public interface IEmployee
    {
         string Name { get; }
         ISalary Salary { get; }
    }
}
