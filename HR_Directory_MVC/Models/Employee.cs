using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Directory_MVC.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public bool EmployedOrNot { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Department { get; set; }
        public int Supervisor { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public double PayRate { get; set; }
        public string Certifications { get; set; }
        public int PermissionLevel { get; set; }

        public Employee()
        {

        }
    }
}
