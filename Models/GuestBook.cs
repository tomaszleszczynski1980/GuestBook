using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GuestBook.Models;

namespace GuestBook.Models
{
    public class GuestBook
    {
        public int ID { get; set; }
        
        [Required, StringLength(160, MinimumLength = 3)]
        public string Message { get; set; }
        
        [Required, StringLength(20)]
        public string Name { get; set; }
        
        public virtual ICollection<Comment> Comment {get; set;}
        
    }
}