using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeePayrollMultithreading
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeDetails> list = new List<EmployeeDetails>();
        public void AddEmployeeToPayroll(List<EmployeeDetails> list)
        {
            list.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);
            });
            Console.WriteLine("No. of employees: " + EmployeeCount());
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Thread: " + thread.ManagedThreadId);
        }

        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            list.Add(emp);
        }
        public int EmployeeCount()
        {
            return this.list.Count;
        }
        public void AddEmployeeToPayrollWithThread(List<EmployeeDetails> list)
        {
            list.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    AddEmployeePayroll(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.EmployeeName);
                });
                thread.Start();
            });
        }
    }
}

       