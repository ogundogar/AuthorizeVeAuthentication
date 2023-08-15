using Microsoft.EntityFrameworkCore;

namespace AuthorizeVeAuthentication.Models.IRepository
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}
