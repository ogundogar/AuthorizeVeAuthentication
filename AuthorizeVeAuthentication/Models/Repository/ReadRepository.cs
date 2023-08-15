using AuthorizeVeAuthentication.Models.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AuthorizeVeAuthentication.Models.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        Context _context = new Context();
        public ReadRepository(Context context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
    }
}
