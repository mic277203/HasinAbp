using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hasin.Authorization;
using Hasin.Categorys.Mapper;
using Hasin.Products.Mapper;

namespace Hasin
{
    [DependsOn(
        typeof(HasinCoreModule),
        typeof(AbpAutoMapperModule))]
    public class HasinApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HasinAuthorizationProvider>();

            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                CategoryMapper.CreateMappings(config);
                ProductMapper.CreateMappings(config);
            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HasinApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
