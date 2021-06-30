namespace TaxCalculator.Models
{
    using System;
    using TaxCalculator.Models.Contracts;
    using TaxCalculator.Utilities.Messages;
    public class Employee : IEmployee
    {
        private string name;

        public Employee(string name, ISalary salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }

                this.name = value;
            }
        }

        public ISalary Salary { get; private set; }
    }
}
