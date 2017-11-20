﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blogs.Models
{
    /// <summary>
    /// This is the model for a Post on the Blog.
    /// </summary>
    public class Post
    {
        [Required]
        [Key]
        public int PostID { get; set; }

        [Required]
        public DateTime DatePosted { get; set; } = DateTime.Now;

        public DateTime DateEdited { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public String Body { get; set; }

        [Required]
        public String UserID { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}