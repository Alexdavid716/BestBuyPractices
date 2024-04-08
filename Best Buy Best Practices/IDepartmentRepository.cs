using System;
namespace Best_Buy_Best_Practices
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetAllDepartments();
		public void InsertDepartment(string newDepartmentName);
	}

}

