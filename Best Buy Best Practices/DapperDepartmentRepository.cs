using System;
using System.Data;
using Dapper;

namespace Best_Buy_Best_Practices
{
	public class DaperDepartmentRepository : IDepartmentRepository

	{
		private readonly IDbConnection _connection;

		public DaperDepartmentRepository(IDbConnection connection)
		{
			_connection = connection;
		}

        public IEnumerable<Department> GetAllDepartments()
        {
			return _connection.Query<Department>("SELECCT * FROM Departments;");
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentname);",
                new { departmentname = newDepartmentName });
        }
    }
    }





 