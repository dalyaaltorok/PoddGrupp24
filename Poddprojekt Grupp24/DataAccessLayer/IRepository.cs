using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        T GetByName(String  name);
        List<T> GetAll();
        void Add(T element);
        void Update(T element, int index);
        void Delete(int index);
        void SaveAll();
        
    }
}
