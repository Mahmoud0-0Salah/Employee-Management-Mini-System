using Employee_Management_Mini_System.Models;
using Employee_Management_Mini_System.Models.JunctionTables;
using System.Linq.Expressions;

namespace Employee_Management_Mini_System.Services.Contracts
{
	public interface IEmployeeService
	{
		public void CreateEmployee(Employee employee);
		public Task DeleteEmployee(int employeeId);
		void UpdateeEmployee(Employee employee);
		public Task<PagedData<Employee>> GetEmployees(int PageNumber, int PageSize);
		public Task<PagedData<Employee>> GetEmployeesByCondition(Expression<Func<Employee, bool>> predicate, int PageNumber, int PageSize = 10);
		public Task Save();
	}
}

