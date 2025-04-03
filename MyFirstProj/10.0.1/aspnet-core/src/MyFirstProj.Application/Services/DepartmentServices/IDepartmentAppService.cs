using System;
using Abp.Application.Services;
using MyFirstProj.Services.DepartmentServices.Dtos;

namespace MyFirstProj.Services.DepartmentServices
{
    public interface IDepartmentAppService:IAsyncCrudAppService<DepartmentDto,Guid>
    {

    }
}
