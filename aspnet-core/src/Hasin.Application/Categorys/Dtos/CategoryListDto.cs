

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using Hasin.Categorys;

namespace Hasin.Categorys.Dtos
{
    public class CategoryListDto : EntityDto<long>
    {
        /// <summary>
        /// Name
        /// </summary>
        [MaxLength(100)]
        [Required(ErrorMessage = "Name不能为空")]
        public string Name { get; set; }
    }
}