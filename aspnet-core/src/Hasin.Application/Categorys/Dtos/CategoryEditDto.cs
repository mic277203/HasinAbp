
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Hasin.Categorys;

namespace Hasin.Categorys.Dtos
{
    public class CategoryEditDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [MaxLength(100)]
        [Required(ErrorMessage = "Name不能为空")]
        public string Name { get; set; }
    }
}