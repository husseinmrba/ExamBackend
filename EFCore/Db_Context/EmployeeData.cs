using EFCore.Db_Context.Interfaces;
using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Db_Context
{
    internal class EmployeeData : IEmployee
    {

        public void AddEmployee(Employee employee)
        {
            using (var context = new AppDbContext())
            {
                if (employee != null)
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }
            }
        }

        public Employee GetEmployee(int employeeId)
        {
            using (var context = new AppDbContext())
            {
                var employee = context.Employees.
                    Include(e => e.Tasks).
                    TagWith("Get employee by id").
                    FirstOrDefault(e => e.EmployeeId == employeeId);
                return employee;
            }
        }

        public List<Employee> GetEmployees()
        {
            using (var context = new AppDbContext())
            {
                var employees = context.Employees.TagWith("Get employees").Include(e => e.Tasks).ToList();
                return employees;
            }
        }
    }
}
