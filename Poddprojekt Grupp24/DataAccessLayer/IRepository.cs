using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByName(String  name);
        Task<IEnumerable<T>> GetAll(); //Asynkron metod som hämtar alla element av vald typ (T). Kräver "await" vid instansiering. Enumerable tillåter vilken list-type som helst.
        Task<T> Add(T element);
        Task<T> Update(T element);
        Task Delete(T element);
        
    }
}
