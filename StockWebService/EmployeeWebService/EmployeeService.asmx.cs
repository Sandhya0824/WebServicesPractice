using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EmployeeWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        List<Employee> employees = new List<Employee>();

        [WebMethod(MessageName = "For adding an employee and getting the whole employee list")]
        public List<Employee> AddEmployee(string firstName, string lastName, int employeeID)
        {
            employees.Add(new Employee(firstName, lastName, employeeID));
            return employees;
        }

        [WebMethod(MessageName = "For removing an employee and getting the whole employee list")]
        public List<Employee> RemoveEmployee(int id)
        {
            Employee employee = employees.Find(emp => emp.employeeID == id);
            if (employee == null)
            {
                return employees;
            }
            else
            {
                employees.Remove(employee);
                return employees;
            }
        }

        [WebMethod(MessageName = "For updating the first name of an employee and getting the whole employee list")]
        public List<Employee> UpdateEmployeeFirstName(int id, string firstName)
        {
            Employee employee = employees.Find(emp => emp.employeeID == id);
            if (employee == null)
            {
                return employees;
            }
            else
            {
                employee.firstName = firstName;
                return employees;
            }
        }

        [WebMethod(MessageName = "For updating the last name of an employee and getting the whole employee list")]
        public List<Employee> UpdateEmployeeLastName(int id, string lastName)
        {
            Employee employee = employees.Find(emp => emp.employeeID == id);
            if (employee == null)
            {
                return employees;
            }
            else
            {
                employee.lastName = lastName;
                return employees;
            }
        }

        [WebMethod(MessageName = "For getting tha name of the employee")]
        public Employee GetEmployee(int id)
        {
            Employee employee = employees.Find(emp => emp.employeeID == id);
            return employee;
        }
    }
}

