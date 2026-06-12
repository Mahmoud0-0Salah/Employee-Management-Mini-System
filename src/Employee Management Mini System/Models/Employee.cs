using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Management_Mini_System.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Full name is required.")]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 100 characters.")]
		public string FullName { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email format.")]
		[StringLength(150)]
		public string Email { get; set; }

		[Required]
		[RegularExpression(@"^\+?[0-9]{8,15}$",
		ErrorMessage = "Phone number must contain 8-15 digits and may start with '+'.")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Job title is required.")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Job title must be between 2 and 100 characters.")]
		public string JobTitle { get; set; }

		[Required(ErrorMessage = "Hire date is required.")]
		[DataType(DataType.Date)]
		public DateTime HireDate { get; set; }

		[Required]
		public bool IsActive { get; set; } = true;

		[ForeignKey("Department")]
		public int DepartmentId { get; set; }
		public Department Department { get; set; }
	}
}