﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ArticleNumber { get; set; }
    }
}
