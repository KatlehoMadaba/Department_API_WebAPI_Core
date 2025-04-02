using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstProj.Services.DepartmentServices.Dtos;

namespace MyFirstProj.Services.DepartmentServices
{
    public interface IDepartmentAppService:IAsyncCrudAppService<DepartmentDto,Guid>
    {

    }
}
