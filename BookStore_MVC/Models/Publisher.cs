using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Models
{
    public class Publisher
    {
        [ScaffoldColumn(false)]
        public int PublisherId { get; set; }
        [Display(Name = "Publisher")]
        public string PublisherName { get; set; }
    }
}