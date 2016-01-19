﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public string BookIsbn { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Book Book { get; set; }
    }
}