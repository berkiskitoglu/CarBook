﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public int BlogID { get; set; }
    }
}
