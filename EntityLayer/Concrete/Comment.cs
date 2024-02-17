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
        public string CommentUser { get; set; } = null!;
        public string CommentContent { get; set; } = null!;
        public DateTime CommentDate { get; set; }
        public bool CommentState { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; } = null!;
    }
}
