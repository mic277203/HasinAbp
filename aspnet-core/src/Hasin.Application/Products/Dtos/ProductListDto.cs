

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using Hasin.Products;
using Hasin.Categorys;

namespace Hasin.Products.Dtos
{
    public class ProductListDto : EntityDto<long>, IFullAudited
    {


        /// <summary>
        /// Name
        /// </summary>
        [MaxLength(100)]
        [Required(ErrorMessage = "Name不能为空")]

        /// <summary>
        /// CategoryId
        /// </summary>
        public long CategoryId { get; set; }


        /// <summary>
        /// CreatorUserId
        /// </summary>
        public long? CreatorUserId { get; set; }


        /// <summary>
        /// CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }


        /// <summary>
        /// LastModifierUserId
        /// </summary>
        public long? LastModifierUserId { get; set; }


        /// <summary>
        /// LastModificationTime
        /// </summary>
        public DateTime? LastModificationTime { get; set; }



        /// <summary>
        /// IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }



        /// <summary>
        /// DeleterUserId
        /// </summary>
        public long? DeleterUserId { get; set; }


        /// <summary>
        /// DeletionTime
        /// </summary>
        public DateTime? DeletionTime { get; set; }

    }
}