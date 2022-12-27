namespace Lesson34.WebService;

public class CompanyRepository : ICompanyRepository
{
    private readonly NewDbContext _context;
    public CompanyRepository(NewDbContext context) => _context = context;

    public async Task<Department> GetDepartmentAsync() =>
        await _context.Set<Department>()
            .Include(department => department.Users)
            .ThenInclude(user1 => user1.Details)
            .FirstAsync();

    public async Task AddUserAsync(UserModel user)
    {
        await _context.Users.AddAsync(new User(user));
        await _context.SaveChangesAsync();
    }
}