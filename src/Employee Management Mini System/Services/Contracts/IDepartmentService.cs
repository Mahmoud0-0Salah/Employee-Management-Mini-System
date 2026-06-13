using Employee_Management_Mini_System.Models;

namespace Employee_Management_Mini_System.Services.Contracts
{
	public interface IDepartmentService
	{
		public Task<IEnumerable<Department>> GetDepartments();

	}
}

