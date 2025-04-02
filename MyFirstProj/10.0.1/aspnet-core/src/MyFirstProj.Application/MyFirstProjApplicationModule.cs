using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstProj.Authorization;

namespace MyFirstProj;

[DependsOn(
    typeof(MyFirstProjCoreModule),
    typeof(AbpAutoMapperModule))]
public class MyFirstProjApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<MyFirstProjAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(MyFirstProjApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
