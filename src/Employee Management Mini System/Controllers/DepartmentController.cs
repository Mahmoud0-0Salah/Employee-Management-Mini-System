using Employee_Management_Mini_System.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management_Mini_System.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentService _departmentService;
		public DepartmentController(IDepartmentService departmentService)
		{
			_departmentService = departmentService;
		}
		public async Task<IActionResult> Index()
		{
			var departments = await _departmentService.GetDepartments();
			return Json(departments);
		}
	}
}
