using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace webapi_learning.Models
{
    public class Product
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "用户编号不能为空")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}