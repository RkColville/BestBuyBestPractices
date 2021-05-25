using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BestBuyBestPractices
{
    public class Department_Repo : IDepartmentRepo
    {
        private readonly IDbConnection _connection;

        //Constructor
        public Department_Repo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }
        public Department GetDepartment(int id)
        {
            return _connection.QuerySingle<Department>("SELECT * FROM departments WHERE DepartmentID = @id;",
                new { id = id });
        }
        public void InsertDepartment(string name)
        {
            _connection.Execute("INSERT INTO departments (Name) VALUES (@name);", 
                new {name = name });
        }
        public void UpdateDepartment(int id, string newName)
        {
            _connection.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @ID;",
                new {id = id, newName = newName});
        }
        public void DeleteDepartment(int id)
        {
            _connection.Execute("DELETE FROM departments WHERE DepartmentID =@id;",
                new { id = id });
        }
        


        
       

        
    }
}
