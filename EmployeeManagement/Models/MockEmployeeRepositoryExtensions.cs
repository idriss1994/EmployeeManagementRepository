using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class MockEmployeeRepositoryExtensions
    {
   
        public static Employee Find(this MockEmployeeRepository mockEmpRepo, int id)
        {
            return mockEmpRepo.GetAllEmployee().FirstOrDefault(e => e.Id == id);
        }
    }
}
