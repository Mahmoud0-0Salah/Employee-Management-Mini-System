using Employee_Management_Mini_System.Data;
using Employee_Management_Mini_System.Repositories.Contracts;
using System.Linq.Expressions;

namespace Employee_Management_Mini_System.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationDbContext context;

		public Repository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public void Create(T entity)
		{
			context.Set<T>().Add(entity);
		}

		public void Delete(T entity)
		{
			context.Set<T>().Remove(entity);
		}

		public IQueryable<T> GetAll()
		{
			return context.Set<T>();
		}

		public IQueryable<T> GetByCondition(Expression<Func<T, bool>> predicate)
		{
			return context.Set<T>().Where(predicate);
		}

		public void Save()
		{
			context.SaveChanges();
		}

		public void Update(T entity)
		{
			context.Set<T>().Update(entity);
		}
	}
}
