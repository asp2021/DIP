using System;
using System.Collections.Generic;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Veronica", Gender = Gender.Female, Role = Role.Developer},
                new Employee { Name = "Miguel", Gender = Gender.Male , Role = Role.Executive},
                new Employee { Name = "Pao", Gender = Gender.Female, Role = Role.Executive},
                new Employee { Name = "Lore", Gender = Gender.Female, Role = Role.Developer}
            };

            var employeManager = new EmployeeManager();
            foreach(var employee in employees)
            {
                employeManager.Save(employee);
            }

            var search = new EmployeeSearch(employeManager);
            Console.WriteLine("SOLID" + '\n');
            Console.WriteLine("DIP - Dependency inversion principle" + '\n');
            Console.WriteLine("Los modulos de alto nivel no deben depender de los modulos de bajo nivel a no ser que sea mediante una abstraccion" + '\n');

            Console.WriteLine($"Cantidad de Empleados Ejecutivos y de genero masculino: {search.GetMaleExecutives()}");
        }
    }
}
