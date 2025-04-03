using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using MyFirstProj.Domain;
using MyFirstProj.Domain.Enums;

namespace MyFirstProj.Services.PersonServices.Dto
{
    //We are taking the PersonRequestDto is basically the request payload that user will see when creating the user
    [AutoMapTo(typeof(Person))]
    public class PersonRequestDto
    {
        public ReflistTitle? Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public long UserId { get; set; }//FK USER 
    }
}
