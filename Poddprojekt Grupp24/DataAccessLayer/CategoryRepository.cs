using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository : IRepository<Category>
    {
        Serializer<Category> dataSerialize;
        List<Category> listCategories;

        public CategoryRepository(string path)
        {
            dataSerialize = new Serializer<Category>(path);
            listCategories = dataSerialize.Deserialize();
            GetAll();
        }

        public List<Category> GetAll()
        {
            return listCategories;
        }


        public Category GetByName(string name) 
        {
            foreach (Category category in listCategories) 
            {
                if (category.Name == name)
                {
                    return category;
                }
            }   return null;
                
        }

        public void Add(Category category)
        {
            listCategories.Add(category);
            SaveAll();
        }

        public void Update(Category category)
        {
            for (int i = 0; i < listCategories.Count; i++)
            {
                listCategories[i] = category;
                SaveAll();
                return;
            }

        }

        public void Delete(Category category)
        {
            listCategories.Remove(category);
            SaveAll();
        }

        public void SaveAll()
        {
            dataSerialize.Serialize(listCategories);
        }
    }
}
