﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBook.Domain.Entities;

namespace ZooBook.Domain.Interfaces
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
    }
}
