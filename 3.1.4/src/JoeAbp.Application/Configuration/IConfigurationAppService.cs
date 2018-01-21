using System.Threading.Tasks;
using Abp.Application.Services;
using JoeAbp.Configuration.Dto;

namespace JoeAbp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}