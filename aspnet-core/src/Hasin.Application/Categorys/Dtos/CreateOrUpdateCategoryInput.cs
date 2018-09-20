

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hasin.Categorys;

namespace Hasin.Categorys.Dtos
{
    public class CreateOrUpdateCategoryInput
    {
        [Required]
        public CategoryEditDto Category { get; set; }

    }
}