using System;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;

namespace MyFirstProj.Domain
{
    //An employee can work for a department but a department can have many employees
    public class Department : AuditedEntity<Guid>
    {
        public string Name { get; set; }
        public IList<Employee> Employee { get; set; }     

    }
}
