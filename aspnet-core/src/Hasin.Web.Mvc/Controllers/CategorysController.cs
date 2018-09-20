using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Hasin.Authorization;
using Hasin.Categorys;
using Hasin.Categorys.Dtos;
using Hasin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Hasin.Web.Mvc.Controllers
{
    public class CategorysController : HasinControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategorysController(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }
        public async Task<ActionResult> Index()
        {
            var input = new GetCategorysInput() { MaxResultCount = 20, SkipCount = 0 };
            var categorys = await _categoryAppService.GetPaged(input);

            return View(categorys);
        }

        public async Task<ActionResult> EditCategoryModal(long categoryId)
        {
            var categoryDto = await _categoryAppService.GetForEdit(new NullableIdDto<long>() { Id = categoryId });

            return View("_EditCategoryModal", categoryDto);
        }
    }
}