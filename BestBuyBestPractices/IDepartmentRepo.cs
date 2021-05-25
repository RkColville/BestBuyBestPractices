using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();
        public Department GetDepartment(int id);
        public void InsertDepartment(string name);
        public void UpdateDepartment(int id, string newName);
        public void DeleteDepartment(int id);


    }
}
