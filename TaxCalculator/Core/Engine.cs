namespace TaxCalculator.Core
{
    using System;
    using Contracts;
    using IO.Contracts;
    using Models;
    using Models.Contracts;
    using Utilities.Messages;

    public class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;

        public Engine(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        /// <summary>
        /// Core method for execution of the program.
        /// </summary>
        public void Run()
        {
            string input = reader.ReadLine();

            while (input.ToUpper() != ProgramEndMessage.END)
            {
                try
                {
                    //Suggested input format: {name} {salary}
                    string[] argumets = input.Split();
                    string employeeName = argumets[0];
                    decimal grossSalary = decimal.Parse(argumets[1]);

                    Salary.ValidateGrossSalary(grossSalary);
                    ISalary salary = new Salary(grossSalary);

                    IEmployee employee = new Employee(employeeName, salary);
                    decimal netSalary = employee.Salary.NetAmount;
                    writer.WriteLine(netSalary.ToString("F0"));
                }
                catch (ArgumentNullException ane)
                {
                    writer.WriteLine(ane.Message);
                }
                catch (ArgumentException ae)
                {
                    writer.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    writer.WriteLine(ioe.Message);
                }

                input = reader.ReadLine();
            }
        }

        /// <summary>
        /// Method for creating Employee instance from the customet input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Employee</returns>
        //private Employee CreateEmployeeFromInput(string input)
        //{
        //    //Suggested input format: {name} {salary}
        //    string[] argumets = input.Split();
        //    string employeeName = argumets[0];
        //    decimal grossSalary = decimal.Parse(argumets[1]);

        //    //Salary.ValidateGrossSalary(grossSalary);

        //    //ISalary salary = GetSalaryInstance(grossSalary);

        //    //return new Employee(employeeName, salary);
        //}

        /// <summary>
        /// Creating Salary instance.
        /// </summary>
        /// <param name="grossSalary">grossSalary component from the input</param>
        /// <returns>ISalary</returns>
        private static ISalary GetSalaryInstance(decimal grossSalary)
        {
            return new Salary(grossSalary);
        }
    }
}
