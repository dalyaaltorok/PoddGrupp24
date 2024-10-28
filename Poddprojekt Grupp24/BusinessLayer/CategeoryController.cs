using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;

namespace BusinessLayer
{
    public class CategeoryController
    {
        CategoryRepository categoryRepo;

        public CategeoryController(String path)
        {
            categoryRepo = new CategoryRepository(path);
        }

        public CategeoryController() { }

        public void Add(String name)
        {
            Category category = new Category(name);
            categoryRepo.Add(category);
        }

        public List<Category> GetAll()
        {
            return categoryRepo.GetAll();
        }
    }
}
