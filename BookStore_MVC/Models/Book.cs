using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Models
{
    public class Book
    {
        [Key]
        [Display(Name = "ISBN")]
        public string BookIsbn { get; set; }
        [Display(Name = "Title")]
        public string BookTitle { get; set; }
        [Display(Name = "Author")]
        public string BookAuthor { get; set; }
        [Display(Name = "Image")]
        public string BookImage { get; set; }
        [Display(Name = "Description")]
        public string BookDescr { get; set; }
        [Display(Name = "Price")]
        public decimal BookPrice { get; set; }
        [ScaffoldColumn(false)]
        public virtual Publisher Publisher { get; set; }
    }
}