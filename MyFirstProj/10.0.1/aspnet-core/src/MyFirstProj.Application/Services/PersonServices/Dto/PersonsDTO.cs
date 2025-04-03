using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyFirstProj.Authorization.Users;
using MyFirstProj.Domain;
using MyFirstProj.Domain.Enums;

namespace MyFirstProj.Services.PersonServices.DTO
{
    [AutoMap(typeof(Person))]
    public class PersonsDTO:AuditedEntityDto<Guid>
    {
        public ReflistTitle? Title { get; set; }
        public string TitleText { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Users.Dto.UserDto User { get; set; }
    }
}
