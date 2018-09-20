﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Hasin.Configuration.Dto;

namespace Hasin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HasinAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
