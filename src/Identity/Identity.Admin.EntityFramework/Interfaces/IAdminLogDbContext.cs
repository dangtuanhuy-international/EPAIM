using Identity.Admin.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity.Admin.EntityFramework.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}