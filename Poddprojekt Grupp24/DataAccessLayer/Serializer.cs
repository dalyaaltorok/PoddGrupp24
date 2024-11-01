using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.ServiceModel.Syndication;
using Models;


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

        //tom konsttruktor här för att kunna instansiera serializer i repositories
        public Serializer()
        {
        }
        
        public void Serialize(List<T> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute($"ArrayOf{typeof(List<T>).Name}") { Namespace = "" });
            using (FileStream stream = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, list);
                }
                
        }
        
        public List<T> Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute($"ArrayOf{typeof(List<T>).Name}") { Namespace = "" });
            if (validation.FileExists(Path))
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

        public async Task<SyndicationFeed> DeserializeRSS(string rss)
        {
            XmlReader reader = XmlReader.Create(rss);
            SyndicationFeed stream = SyndicationFeed.Load(reader);
            reader.Close();
            return stream;
        }
    }
}