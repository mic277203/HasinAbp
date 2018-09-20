
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Hasin.Products;
using Hasin.Categorys;

namespace Hasin.Products.Dtos
{
    public class ProductEditDto
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

        /// <summary>
        /// CategoryId
        /// </summary>
        public long CategoryId { get; set; }

    }
}