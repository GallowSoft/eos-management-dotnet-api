using GallowSoft.EosManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GallowSoft.EosManagement.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}