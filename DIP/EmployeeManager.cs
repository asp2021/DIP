using System.Collections.Generic;
using System.Linq;

namespace DIP
{
    public class EmployeeManager : IEmployeeSearchable
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public int GetEmployeeByGenderAndRole(Gender gender, Role role)
        {
            return _employees.Where(x => x.Gender == gender && x.Role == role).ToList().Count();
        }

        public void Save (Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
