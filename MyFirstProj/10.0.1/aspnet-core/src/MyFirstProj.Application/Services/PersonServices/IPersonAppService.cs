using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstProj.Domain;
using MyFirstProj.Services.PersonServices.Dto;
using MyFirstProj.Services.PersonServices.DTO;

namespace MyFirstProj.Services.PersonServices
{
    interface IPersonAppService:IApplicationService
    {
        Task<PersonsDTO> CreatePersonAsync(PersonRequestDto input);
        Task<List<PersonsDTO>> Getall();
    }
}
