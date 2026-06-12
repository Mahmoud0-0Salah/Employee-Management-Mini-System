using Employee_Management_Mini_System.Data;
using Employee_Management_Mini_System.Models;
using Employee_Management_Mini_System.Repositories.Contracts;

namespace Employee_Management_Mini_System.Repositories
{
	public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
