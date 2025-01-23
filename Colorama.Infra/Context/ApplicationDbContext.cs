using Microsoft.EntityFrameworkCore;

namespace Colorama.Domain.Context;

public class ApplicationDbContext : BaseApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}