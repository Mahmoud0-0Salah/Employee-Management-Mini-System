using Employee_Management_Mini_System.Models;
using Employee_Management_Mini_System.Repositories.Contracts;
using Employee_Management_Mini_System.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_Mini_System.Services
{
	public class DepartmentService: IDepartmentService
	{
		private readonly IDepartmentRepository _departmentRepository;
		public DepartmentService(IDepartmentRepository departmentRepository)
		{
			_departmentRepository = departmentRepository;
		}

		public async Task<IEnumerable<Department>> GetDepartments()
		{
			return await _departmentRepository.GetAll().ToListAsync();
		}
	}
}
