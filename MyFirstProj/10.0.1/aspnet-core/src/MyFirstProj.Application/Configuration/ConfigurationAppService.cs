using Abp.Authorization;
using Abp.Runtime.Session;
using MyFirstProj.Configuration.Dto;
using System.Threading.Tasks;

namespace MyFirstProj.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : MyFirstProjAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
