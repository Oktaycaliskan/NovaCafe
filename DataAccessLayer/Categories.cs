﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Categories
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Photo { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveStr { get; set; }
    }
}