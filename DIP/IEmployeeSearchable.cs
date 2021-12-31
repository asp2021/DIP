
namespace DIP
{
    public interface IEmployeeSearchable
    {
        int GetEmployeeByGenderAndRole(Gender gender, Role role);
    }
}
