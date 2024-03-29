﻿using _01.AriBilgi.Blog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _025.AriBilgi.Blog.Entities
{
    public class Comment : EntityBase, IEntity
    {
        public string Content { get; set; }
        public int ArticleId { get; set; }
        public int? UserId { get; set; }

        public Article Article { get; set; }
        public User User { get; set; }
    }
}
