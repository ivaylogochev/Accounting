using NUnit.Framework;
using TaxCalculator.Models;
using TaxCalculator.Models.Contracts;

namespace TaxCalculatorTests
{
    public class Tests
    {
        private ISalary salary;
        private IEmployee employee;

        [SetUp]
        public void Setup()
        {
            salary = new Salary(3400);
            employee = new Employee("Ivo", salary);
        }

        [TestCase]
        public void CannonCreateSalaryWithNegativeOrZeroAmount()
        {
            //Arrange
            salary = new Salary(-2400);
            //Act

            //Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(attacker);
            });
        }
    }
}