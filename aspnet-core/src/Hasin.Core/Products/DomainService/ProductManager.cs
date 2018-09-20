

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using Hasin;
using Hasin.Products;


namespace Hasin.Products.DomainService
{
    /// <summary>
    /// Product领域层的业务管理
    ///</summary>
    public class ProductManager :HasinDomainServiceBase, IProductManager
    {
		
		private readonly IRepository<Product,long> _repository;

		/// <summary>
		/// Product的构造方法
		///</summary>
		public ProductManager(
			IRepository<Product, long> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitProduct()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
