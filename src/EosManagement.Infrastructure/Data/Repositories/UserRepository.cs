using GallowSoft.EosManagement.Core.Entities;
using GallowSoft.EosManagement.Core.Interfaces;

namespace GallowSoft.EosManagement.Infrastructure.Data;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<User> GetAsync(Guid id)
    {
        return await _context.Users.FindAsync(id);
    }
}