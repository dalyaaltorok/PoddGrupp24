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
        private string Path { get; set; }

        ValidationSerializer validation;

        public Serializer(string aPath)
        {
            Path = aPath;
            validation = new ValidationSerializer();
        }

        public Serializer()
        {
        }

        public void Serialize(List<T> list)
        {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (FileStream stream = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, list);
                }
            }
        
        public List<T> Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
            if(validation.DirectoryExists(Path) && validation.FileExists(Path))
            {
                using (FileStream stream = new FileStream(Path, FileMode.Open, FileAccess.Read))
                {
                    List<T> list = (List<T>)deserializer.Deserialize(stream);
                    return list;
                }
            }
            else
            {
                return new List<T>();
            }
        }
    }
}