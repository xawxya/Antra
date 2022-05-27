using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Person
    {
        private string name;

        public virtual void sayName()
        {
            Console.WriteLine("My name is " + this.Name);
        }
        public string Name { get; set; }
        private int age;
        public int Age { get; set; }
        private decimal salary;
        public decimal Salary { 
            get
            {
                return salary;
            } 
            set
            {
                decimal num = -1;
                while (num < 0)
                {
                    Console.WriteLine("Enter a salary bigger than 0");
                    num = Convert.ToDecimal(Console.ReadLine());
                }
                salary = num;
            } 
        }

        private string address;
        public string Address {
            get
            {
                return address;
            }
            set
            {
                Console.WriteLine("Enter an address");
                string add = Console.ReadLine();
                address = add;
            }

        }
        
    }
}
