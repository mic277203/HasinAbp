
using Abp.Runtime.Validation;
using Hasin.Dtos;
using Hasin.Categorys;

namespace Hasin.Categorys.Dtos
{
    public class GetCategorysInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}