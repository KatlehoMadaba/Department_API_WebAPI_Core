using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyFirstProj.Domain;
using MyFirstProj.Services.PersonServices.DtO;

namespace MyFirstProj.Services.DepartmentServices.Dtos
{
    [AutoMap(typeof(Department))]
    public class DepartmentDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        //public IList<EmployeeDto> Employee { get; set; }
    }
}
