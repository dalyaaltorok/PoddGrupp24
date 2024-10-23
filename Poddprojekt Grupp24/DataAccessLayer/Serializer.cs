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
    public class Serializer
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
