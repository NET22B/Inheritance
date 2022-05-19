using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public interface IPerson
    {
        string Name { get; set; }
        void Do();
    }

    internal class Person : IPerson
    {
        public string Name { get; set; }

        public virtual void Do()
        {
            Console.WriteLine("Person doing");
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }
    }  
    
    internal class Admin : Employee
    {
        public string Department { get; set; }

        public override void Do()
        {
            base.Do();
            Console.WriteLine("Admin doing");
        }

        public void TestException(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"'{nameof(input)}' cannot be null or whitespace.", nameof(input));
            }



        }
    }


}
