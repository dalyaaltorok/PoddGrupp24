using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Episode
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Episode(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
