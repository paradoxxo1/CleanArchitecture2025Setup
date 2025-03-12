﻿using CleanArchitecture_2025.Domain.Employees;
using CleanArchitecture_2025.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture_2025.Infrastructure.Repositories;

internal sealed class EmployeeRepository : Repository<Employee, ApplicationDbContext>, IEmployeeRepository
{
    public EmployeeRepository(ApplicationDbContext context) : base(context)
    {
    }
}
