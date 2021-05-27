using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBook.Application.ViewModels;
using ZooBook.Domain.Entities;

namespace ZooBook.Application.Interfaces
{
   public interface IEmployeeService
    {
        Task<List<Employee>> GetAll();

        Task<Employee> Get(string id);

        Task Insert(EmployeeVm entity);

        Task Update(string id, EmployeeVm entity);

        Task Delete(string id);
        Task<bool> EmployeeExists(string id);
    }
}
