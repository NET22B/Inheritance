using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson employee = new Employee();
            IPerson admin = new Admin();

            employee.Do();
            admin.Do();

            //employee.Salary = 50000;
            //Person person = new Person();
            //person = employee;
            

            //Employee employee2 = (Employee)person;
            //employee2.Salary = 10000;
            //var salary = employee2.Salary;

            //Console.WriteLine(employee.Salary);
        }
    }
}
