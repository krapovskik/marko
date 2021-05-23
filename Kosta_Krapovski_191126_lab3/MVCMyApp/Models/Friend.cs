using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMyApp.Models
{
    public class Friend
    {
        [Range(0,200), Required]
        public int FixId { get; set; }
        [Range(0,200), Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Place { get; set; }
    }
}