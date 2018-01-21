using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using JoeAbp.Configuration.Dto;

namespace JoeAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : JoeAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
