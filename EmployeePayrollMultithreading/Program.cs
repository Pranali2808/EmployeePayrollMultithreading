using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultithreading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee payroll using multithreading");
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 1, EmployeeName = "Pranali" });
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 2, EmployeeName = "Jay" });
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 3, EmployeeName = "Avinash" });
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 4, EmployeeName = "Nikhil" });

            EmployeePayrollOperation repo = new EmployeePayrollOperation();
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            repo.AddEmployeeToPayroll(employeeDetails);
            stopWatch1.Stop();
            Console.WriteLine("Duration without multi thread: " + stopWatch1.ElapsedMilliseconds + " ms");

            Console.ReadLine();
        }
    }
}
