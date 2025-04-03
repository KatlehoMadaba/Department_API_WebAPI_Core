using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyFirstProj.Domain;
using MyFirstProj.Services.DepartmentServices.Dtos;

namespace MyFirstProj.Services.DepartmentServices
{
    public class DepartAppService : AsyncCrudAppService<Department, DepartmentDto, Guid>, IDepartmentAppService
    {
        public DepartAppService(IRepository<Department, Guid> repository) : base(repository)
        {

        }
    }

}
