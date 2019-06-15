using System;
using System.ComponentModel.DataAnnotations;

namespace Granite.Models
{
    public class ProductType
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
