using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace Granite.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
