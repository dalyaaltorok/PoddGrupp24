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

        public void RemoveItem(int index)
        {
            categoryRepo.Delete(index);
        }

        public void UpdateItem(string newName, int index)
        {
            var category = categoryRepo.GetAll()[index];
            if (category !=null)
            {
                category.Name = newName;
                categoryRepo.Update(category, index);
                categoryRepo.SaveAll();
            }
        }

    }
}

