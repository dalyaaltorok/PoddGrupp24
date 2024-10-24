using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feed
    {
        private string name;
        private string title;
        private Category category;
        private List<Episode> episodes;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }
        public List<Episode> Episodes
        {
            get { return episodes; }
            set { episodes = value; }
        }

        public Feed(string name, string title, Category category, List<Episode> episodes)
        {
            this.name = name;
            this.title = title;
            this.category = category;
            this.episodes = episodes;
        }

        public Feed()
        {

        }

    }
}