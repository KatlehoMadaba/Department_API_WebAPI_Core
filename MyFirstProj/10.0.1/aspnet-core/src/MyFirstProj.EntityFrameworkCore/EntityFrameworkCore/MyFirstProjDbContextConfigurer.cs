using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MyFirstProj.EntityFrameworkCore;

public static class MyFirstProjDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<MyFirstProjDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<MyFirstProjDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
