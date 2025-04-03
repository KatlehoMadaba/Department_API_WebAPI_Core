using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using MyFirstProj.Authorization.Users;
using MyFirstProj.Domain.Attributes;
using MyFirstProj.Domain.Enums;

namespace MyFirstProj.Domain
{
    [DiscriminatorValue("MyFirstProj.Person")]
    public class Person : AuditedEntity<Guid>
    {
        public ReflistTitle? Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public long UserId { get; set; }//FK USER 
        [ForeignKey("UserId")]
        public User User { get; set; }//User coming from ABP
    }
}
