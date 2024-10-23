using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class Serializer<T>
    {
        private string path { get; set; }

        ValidationSerializer validation;

        public Serializer(string aPath)
        {
            path = aPath;
            validation = new ValidationSerializer();
        }
        public void Serialize(List<T> list)
        {
            try
            {
                if (!validation.DirectoryExists(path))
                {

                }
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, list);
                }
            }
            catch
            {

            }
        }
        public List<T> Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                List<T> list = (List<T>)deserializer.Deserialize(stream);
                return list;
            }
        }
    }
}
