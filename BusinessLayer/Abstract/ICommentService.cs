﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetCommentsWithDestination();
        public List<Comment> TGetCommentsWithDestinationAndUser(int id);
    }
}
