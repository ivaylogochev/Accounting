namespace TaxCalculator.Models.Contracts
{
    public interface ISalary
    {
        decimal NetAmount { get; }

        decimal GrossAmount { get; }
    }
}
