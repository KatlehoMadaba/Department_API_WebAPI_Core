using MyFirstProj.Domain.Attributes;

namespace MyFirstProj.Domain
{
    [DiscriminatorValue("MyFirstProj.Employee")]
    public class Employee : Person
    {
        public string EmployeeNumber { get; set; }
        public Department Department { get; set; }
    }
}
