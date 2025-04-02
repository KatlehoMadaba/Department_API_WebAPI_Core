using Abp.Zero.EntityFrameworkCore;
using MyFirstProj.Authorization.Roles;
using MyFirstProj.Authorization.Users;
using MyFirstProj.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using MyFirstProj.Domain;

namespace MyFirstProj.EntityFrameworkCore;

public class MyFirstProjDbContext : AbpZeroDbContext<Tenant, Role, User, MyFirstProjDbContext>
{
    /* Define a DbSet for each entity of the application */
    public DbSet<Person>Persons { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department>Departments { get; set; }
    public MyFirstProjDbContext(DbContextOptions<MyFirstProjDbContext> options)
        : base(options)
    {
    }
}
