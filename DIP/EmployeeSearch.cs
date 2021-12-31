
namespace DIP
{
    public class EmployeeSearch
    {
        private readonly IEmployeeSearchable employeeManager;

        public EmployeeSearch(IEmployeeSearchable employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        public int GetMaleExecutives()
        {
            return employeeManager.GetEmployeeByGenderAndRole(Gender.Male, Role.Executive);
        }
    }
}
