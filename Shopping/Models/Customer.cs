using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Shopping.Models
{
    public class Customer
    {
        public string Id { get; set; }
        [Required]
        [DisplayName("Enter your name...")]
        [StringLength(3, MinimumLength = 1 )]
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}