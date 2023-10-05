using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebService
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int employeeID { get; set; }

        public Employee(string firstName, string lastName, int employeeID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeID = employeeID;
        }

        public Employee() { }
    }
}