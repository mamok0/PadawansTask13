using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string Surname;
        private int Age;

        public Employee()
                {
                    Surname = "";
                    Age = 0;
                }

        public Employee(string surname, int age)
                {
                    Surname = (surname == null ? "" : surname);
                    Age = age;
                }

        private string AgeToString()
        {
            return Age.ToString();
        }

        public void SetSurname(string newSurname)
        {
            this.Surname = newSurname;
        }
        
        public string Get_Employee_Info()
        {
            return $"Surname: {this.Surname}, Age: {this.Age}";
        }
    }
}
