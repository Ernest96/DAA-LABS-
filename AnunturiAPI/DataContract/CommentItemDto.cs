﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CommentItemDto
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
    }
}
