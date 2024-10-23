using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace DataAccessLayer
{
    public class Serializer<T>
    {
        private string path { get; set; }
        
        public Serializer (string aPath)
        {
            path = aPath;
        }
        public void Serialize (List<T> list)
        {
            
        }
    }
}
