

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Hasin.Products;


namespace Hasin.Products.DomainService
{
    public interface IProductManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitProduct();



		 
      
         

    }
}
