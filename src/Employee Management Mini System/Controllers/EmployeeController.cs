using Employee_Management_Mini_System.Models;
using Employee_Management_Mini_System.Models.JunctionTables;
using Employee_Management_Mini_System.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management_Mini_System.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeService = employeeService;
		}

		public async Task<IActionResult> Index([FromQuery] int pageNumber = 1)
		{
			int pageSize = 10;

			var employees = await _employeeService.GetEmployees(pageNumber, pageSize);

			ViewData["TotalPages"] = employees.TotalCount;

			return View(employees.Data); 
		}
		public async Task<IActionResult> Search([FromQuery] string searchString = "", [FromQuery] int departmentID = -1, [FromQuery] int pageNumber = 1)
		{
			int pageSize = 10;
			PagedData<Employee> employees;
			if (departmentID == -1)
			{
				employees = await _employeeService.GetEmployeesByCondition(
					e => e.FullName.Contains(searchString) ,
					pageNumber, pageSize);
			}
			else if (searchString == "")
			{
				employees = await _employeeService.GetEmployeesByCondition(
					e =>  e.DepartmentId == departmentID,
					pageNumber, pageSize);
			}
			else
			{
				employees = await _employeeService.GetEmployeesByCondition(
					e => e.DepartmentId == departmentID && e.FullName.Contains(searchString),
					pageNumber, pageSize);
			}
			ViewData["CurrentFilter"] = searchString;
			ViewData["TotalPages"] = employees.TotalCount;

			return View(employees.Data);

		}
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Employee employee)
		{
			if (ModelState.IsValid)
			{
				_employeeService.CreateEmployee(employee);
				await _employeeService.Save();
				return RedirectToAction(nameof(Index));
			}
			return View(employee);
		}

		public async Task<IActionResult> Edit(int id)
		{
			var employees = await _employeeService.GetEmployeesByCondition(e => e.Id == id, 1, 1);
			var employee = employees.Data.FirstOrDefault();

			if (employee == null)
			{
				return NotFound();
			}

			return View(employee);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, Employee employee)
		{
			if (id != employee.Id)
			{
				return BadRequest();
			}

			if (ModelState.IsValid)
			{
				_employeeService.UpdateeEmployee(id);
				await _employeeService.Save();
				return RedirectToAction(nameof(Index));
			}
			return View(employee);
		}

		public async Task<IActionResult> Delete(int id)
		{
			var employees = await _employeeService.GetEmployeesByCondition(e => e.Id == id, 1, 1);
			var employee = employees.Data.FirstOrDefault();

			if (employee == null)
			{
				return NotFound();
			}

			return View(employee);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			_employeeService.DeleteEmployee(id);
			await _employeeService.Save();
			return RedirectToAction(nameof(Index));
		}
	}
}