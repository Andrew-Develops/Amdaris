using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string EmployeeInfo { get { return $"{FirstName} {LastName} {Department}"; } }

        public EmployeeModel(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public string ToString()
        {
            return $"{FirstName} {LastName} {Department}";
        }

    }
}
