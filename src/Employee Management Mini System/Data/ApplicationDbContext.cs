using Employee_Management_Mini_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_Mini_System.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	  : base(options) { }
	
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<Employee>()
				.HasOne(e => e.Department)
				.WithMany(d => d.Employees)
				.HasForeignKey(e => e.DepartmentId);
		}

	}
}
