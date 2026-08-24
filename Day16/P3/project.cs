using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public Employee(int empId, string empName, string department, double salary)
        {
            EmpId = empId;
            EmpName = empName;
            Department = department;
            Salary = salary;
        }
    }
}
