using MyFirstProj.Configuration.Dto;
using System.Threading.Tasks;

namespace MyFirstProj.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
