using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using MyFirstProj.Domain;
using MyFirstProj.Services.PersonServices.DtO;
using MyFirstProj.Services.PersonServices.DTO;

namespace MyFirstProj.Services.PersonServices.DtO
{
    //You can have employee dto but for now we just go to do this way
    [AutoMap(typeof(Employee))]
    public class EmployeeDto:PersonsDTO
    {
        public string EmployeeNumber { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
