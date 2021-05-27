using ZooBook.Domain.Entities;
using ZooBook.Domain.Interfaces;
using ZooBook.Infra.Data.Context;

namespace ZooBook.Infra.Data.Repositories
{
    public class  EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ZooBookDbContext dbContext)
          : base(dbContext)
        {

        }
    }
}
