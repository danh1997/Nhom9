using System.Threading.Tasks;
using Abp.Application.Services;
using HuflitBigPrj.Configuration.Dto;

namespace HuflitBigPrj.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}