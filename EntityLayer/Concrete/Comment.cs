﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string? CommentUser { get; set; }
        public string? CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentState { get; set; }
        public int DestinationId { get; set; }
        public Destination? Destination { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
