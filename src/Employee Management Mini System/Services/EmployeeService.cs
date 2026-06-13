using Employee_Management_Mini_System.Models;
using Employee_Management_Mini_System.Models.JunctionTables;
using Employee_Management_Mini_System.Repositories.Contracts;
using Employee_Management_Mini_System.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Employee_Management_Mini_System.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository _employeeRepository;
		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public void CreateEmployee(Employee employee)
		{
			_employeeRepository.Create(employee);
		}

		public async void DeleteEmployee(int employeeId)
		{
			Employee? employee = await _employeeRepository.GetByCondition(e => e.Id == employeeId).SingleOrDefaultAsync();
			_employeeRepository.Delete(employee);
		}

		public async void UpdateeEmployee(int employeeId)
		{
			Employee? employee = await _employeeRepository.GetByCondition(e => e.Id == employeeId).SingleOrDefaultAsync();
			_employeeRepository.Update(employee);
		}

		public async Task<PagedData<Employee>> GetEmployees(int PageNumber,int PageSize = 10)
		{
			var totalCount = await _employeeRepository.GetAll().CountAsync();
			var employees = await _employeeRepository.GetAll().Skip((PageNumber - 1) * PageSize).Take(PageSize).ToListAsync();
			return  new PagedData<Employee> { Data = employees, TotalCount = totalCount };
		}

		public async Task<PagedData<Employee>> GetEmployeesByCondition(Expression<Func<Employee, bool>> predicate, int PageNumber, int PageSize = 10)
		{
			var totalCount = await _employeeRepository.GetByCondition(predicate).CountAsync();
			var employees = await _employeeRepository.GetByCondition(predicate).Skip((PageNumber - 1) * PageSize).Take(PageSize).ToListAsync();
			return new PagedData<Employee> { Data = employees, TotalCount = totalCount };
		}

		public async Task Save()
		{
			await _employeeRepository.Save();
		}
	}
}
