using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_Lib
{
    public class EmployeeDetails
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public EmployeeDetails(int employeeID, string firstName, string lastName,
            DateTime birthDate)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public EmployeeDetails() { }
    }
}
