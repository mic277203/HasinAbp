using System.Threading.Tasks;
using Hasin.Configuration.Dto;

namespace Hasin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
