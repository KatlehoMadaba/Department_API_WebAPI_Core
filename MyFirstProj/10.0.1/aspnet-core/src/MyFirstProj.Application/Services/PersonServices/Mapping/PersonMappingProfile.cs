using AutoMapper;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using MyFirstProj.Domain;
using MyFirstProj.Services.Helpers;
using MyFirstProj.Services.PersonServices.DTO;

namespace MyFirstProj.Services.PersonServices.Mapping
{
    class PersonMappingProfile:Profile
    {
        public PersonMappingProfile()
        {
            //<source ,destination>
            CreateMap<Person, PersonsDTO>()
                //TitleText is a property in the PersonsDTO class,what you are mapping into
                //The Title from the source class is will be checked if it is not null
                //Then the Title.GetEnumDescription() to get the description
                //and maps it to  in the DTO class.
                .ForMember(p => p.TitleText, m => m.MapFrom(e => e.Title != null ? e.Title.GetEnumDescription() : null));
            CreateMap<PersonsDTO, Person>()
                .ForMember(p => p.Id, e => e.Ignore());
                
        }
    }
}
