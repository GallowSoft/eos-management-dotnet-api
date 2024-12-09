using GallowSoft.EosManagement.Core.Entities;

namespace GallowSoft.EosManagement.Core.Interfaces;

public interface IUserRepository
{
    Task<User> GetAsync(Guid id);
}