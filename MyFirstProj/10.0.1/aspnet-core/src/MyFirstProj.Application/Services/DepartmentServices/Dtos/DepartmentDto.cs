using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyFirstProj.Domain;

namespace MyFirstProj.Services.DepartmentServices.Dtos
{
    [AutoMap(typeof(Department))]
    public class DepartmentDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        //public IList<EmployeeDto> Employee { get; set; }
    }
}
