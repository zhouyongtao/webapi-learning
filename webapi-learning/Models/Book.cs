using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace webapi_learning.Models
{
    public class Book
    {
        [Display(Name="是否启用")]
        [DefaultValue(true),Description("默认属性true")]
        public bool Enable { get; set; }
    }
}
