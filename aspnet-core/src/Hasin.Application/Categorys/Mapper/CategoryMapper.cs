
using AutoMapper;
using Hasin.Categorys;
using Hasin.Categorys.Dtos;

namespace Hasin.Categorys.Mapper
{

	/// <summary>
    /// 配置Category的AutoMapper
    /// </summary>
	internal static class CategoryMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Category,CategoryListDto>();
            configuration.CreateMap <CategoryListDto,Category>();

            configuration.CreateMap <CategoryEditDto,Category>();
            configuration.CreateMap <Category,CategoryEditDto>();

        }
	}
}
