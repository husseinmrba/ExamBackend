using EFCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Db_Context.Interfaces
{
    internal interface IEmployee
    {
        void AddEmployee(Employee employee);

        List<Employee> GetEmployees();
        Employee GetEmployee(int employeeId);



    }
}
