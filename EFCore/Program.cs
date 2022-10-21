using EFCore.Db_Context;
using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Task = EFCore.Domain.Task;
namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var createdDatabase = context.Database.EnsureCreated();
            }
                //Employee employee = new Employee()
                //{
                //    FirstName = "Alaa",
                //    LastName = "Eddin",
                //    Salary = 100,
                //    Tasks = new List<Task>() {
                //        new Task(){ TaskName = "C++" , CreatedAt = DateTime.Now },
                //        new Task(){ TaskName = "Php" , CreatedAt = DateTime.Now },
                //        new Task(){ TaskName = "C#" , CreatedAt = DateTime.Now },
                //        new Task(){ TaskName = "Jave" , CreatedAt = DateTime.Now },
                //    }
                //};
                EmployeeData employeeData = new EmployeeData();
            //employeeData.AddEmployee(employee);
            var employees = employeeData.GetEmployees();
            var employee = employeeData.GetEmployee(1);
            
            using(AppDbContext context = new AppDbContext())
            {
                // where
                var employee2 = context.Employees
                    .Include(e => e.Tasks)
                    .Where(e => e.FirstName.Contains("Alaa"))
                    .ToList();

                // like
                var employee3 = context.Employees
                    .Include(e => e.Tasks)
                    .Where(e => EF.Functions.Like(e.FirstName, "%a%"))
                    .ToList();
                // first employee
                var firstEmployee = context.Employees.FirstOrDefault(e => e.FirstName.Contains("Alaa"));
                // change employee
                var updateNameFromHusseinToIssa = context.Employees.FirstOrDefault(e => e.FirstName.Contains("Hussein"));
                if (updateNameFromHusseinToIssa != null)
                {
                    updateNameFromHusseinToIssa.FirstName = "Issa";
                    //context.Employees.Update(updateNameFromHusseinToIssa);
                    context.SaveChanges();
                }
                // get employess with tasks with categories
                var employeesW = context.Employees
                                        .Include(e => e.Tasks)
                                        .ThenInclude(t => t.Categories)
                                        .ToList();
                // include with where
                var employeeIncludeWithWhere = context.Employees
                                                      .Include(e => e.Tasks.Where(t => t.TaskId != 1))
                                                      .Where(e => e.EmployeeId > 3)
                                                      .ToList();
                // get Task to employee
                var employeee = context.Employees.FirstOrDefault(e => e.EmployeeId == 4);
                context.Entry(employeee).Collection(e => e.Tasks).Load();
                // select
                var employeesSelect = context.Employees
                                                .Select(e => new { Id = e.EmployeeId, FirstName = e.FirstName })
                                                .ToList();
                // write query sql
                var employeess = context.Employees.FromSqlRaw("select * from Employees").ToList();
                // seed data json
                var content = File.ReadAllText("jsconfig1.json");
                var defaultEmployee = JsonSerializer.Deserialize<List<Employee>>(content);
                context.Employees.AddRange(defaultEmployee);
                context.SaveChanges();
            }
        }
    }
}