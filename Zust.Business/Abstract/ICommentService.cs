﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Models;

namespace Zust.Business.Abstract
{
    public interface ICommentService
    {
        Task AddAsync(Comment comment);
        Task<IEnumerable<Comment>> GetCommentsOfPostAsync(string postId);
        Task DeleteUserCommentsAsync(string userId);
        Task DeleteCommentAsync(Comment comment);
    }
}
