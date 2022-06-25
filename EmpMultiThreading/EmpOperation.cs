using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMultiThreading
{
    public class EmpOperation
    {
        public class EmployeePayrollOperation
        {
            public List<DetailsEmp> employeeDatalist = new List<DetailsEmp>();
            public void AddEmployee(List<DetailsEmp> employeeDatalist)
            {
                employeeDatalist.ForEach(employeeData =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.Name);
                    this.AddEmployeePayroll(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.Name);
                }
                );
                Console.WriteLine(this.employeeDatalist.ToString());
            }
            public void AddEmployeePayroll(DetailsEmp employee)
            {
                employeeDatalist.Add(employee);
            }
        }
    }
}
