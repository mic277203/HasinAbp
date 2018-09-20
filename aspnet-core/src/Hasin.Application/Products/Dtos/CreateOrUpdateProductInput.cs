

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hasin.Products;

namespace Hasin.Products.Dtos
{
    public class CreateOrUpdateProductInput
    {
        [Required]
        public ProductEditDto Product { get; set; }

    }
}