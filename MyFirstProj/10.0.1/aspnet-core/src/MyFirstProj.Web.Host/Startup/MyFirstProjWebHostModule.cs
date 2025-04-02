using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstProj.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyFirstProj.Web.Host.Startup
{
    [DependsOn(
       typeof(MyFirstProjWebCoreModule))]
    public class MyFirstProjWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstProjWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstProjWebHostModule).GetAssembly());
        }
    }
}
