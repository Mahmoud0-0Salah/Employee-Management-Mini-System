namespace Employee_Management_Mini_System.Models.JunctionTables
{
	public class PagedData<T>
	{
		public IEnumerable<T> Data { get; set; }
		public int TotalCount { get; set; }
	}
}
