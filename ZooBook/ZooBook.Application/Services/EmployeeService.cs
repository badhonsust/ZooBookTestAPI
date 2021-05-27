using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBook.Application.Interfaces;
using ZooBook.Application.ViewModels;
using ZooBook.Domain.Entities;
using ZooBook.Domain.Interfaces;

namespace ZooBook.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task Delete(string id)
        {
            try
            {
                await _repo.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Employee> Get(string id)
        {
            return await _repo.Get(id);
        }

        public Task<List<Employee>> GetAll()
        {
            return _repo.GetAll();
        }

        public async Task Insert(EmployeeVm entity)
        {
            try
            {
                var model = new Employee();
                FillModel(model, entity);

                await _repo.Insert(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Update(string id, EmployeeVm entity)
        {
            try
            {
                var model = await _repo.Get(id);
                FillModel(model, entity);

                await _repo.Update(id,model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillModel(Employee model, EmployeeVm entity)
        {
            model.FirstName = entity.FirstName;
            model.LastName = entity.LastName;
            model.MiddleName = entity.MiddleName;
            model.LastModifiedTime = DateTime.Now;
        }

        public async Task<bool> EmployeeExists(string id)
        {
            return await _repo.IsExists(id);
        }

       
    }
}
