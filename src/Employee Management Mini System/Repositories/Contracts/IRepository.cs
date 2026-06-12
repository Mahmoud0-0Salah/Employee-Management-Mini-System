using System.Linq.Expressions;

namespace Employee_Management_Mini_System.Repositories.Contracts
{
	public interface IRepository<T>
	{
		public IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate);
		public IQueryable<T> GetAll();
		public void Create(T entity);
		public void Update(T entity);
		public void Delete(T entity);
		public void Save();
	}
}
