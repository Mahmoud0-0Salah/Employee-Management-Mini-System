using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Management_Mini_System.Models
{
	public class Department
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Full name is required.")]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 100 characters.")] 
		public string Name { get; set; }
		public ICollection<Employee> Employees { get; set; }
	}
}
