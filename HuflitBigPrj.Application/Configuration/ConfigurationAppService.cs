using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HuflitBigPrj.Configuration.Dto;

namespace HuflitBigPrj.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HuflitBigPrjAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
