﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name
;
        }
    }
}
