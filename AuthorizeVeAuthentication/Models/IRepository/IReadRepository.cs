using System.Linq.Expressions;

namespace AuthorizeVeAuthentication.Models.IRepository
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
    }
}
