﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Category(String name)
        {
            this.name = name;
        }

        public Category()
        {

        }

    }
}
