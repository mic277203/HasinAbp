using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Hasin.Categorys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hasin.Products
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Product : Entity<long>, IFullAudited
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(100)]
        public virtual string Name { get; set; }
        /// <summary>
        /// 类别编号
        /// </summary>
        [Required]
        public virtual long CategoryId { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long? CreatorUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 最后修改用户
        /// </summary>
        public long? LastModifierUserId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 是否软删除
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 删除人
        /// </summary>
        public long? DeleterUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletionTime { get; set; }
    }
}
