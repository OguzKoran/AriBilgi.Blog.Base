﻿using _01.AriBilgi.Blog.Shared;
using _025.AriBilgi.Blog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AriBilgi.Blog.Data.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
