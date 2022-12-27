namespace Lesson34.WebService;

public interface ICompanyRepository
{
    Task<Department> GetDepartmentAsync();
    Task AddUserAsync(UserModel user);
}