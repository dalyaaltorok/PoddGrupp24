using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using BusinessLayer;

namespace PresentationLayer
{
    public class ValidationPL
    {

        FeedController feedController;
        CategeoryController categoryController;
        HttpClient httpClient;

        public ValidationPL(string path)
        {
            feedController = new FeedController(path);
            categoryController = new CategeoryController();
            httpClient = new HttpClient();
        }
        public async Task<bool> ValidateRSSUrlAsync(string url)
        {
            try
            {
                var response = await httpClient.GetAsync(url); //Asynk metod som försöker upprätta en anslutning till websidan. Returnerar en statuskod ex. 404 eller 2xx.
                if (!response.IsSuccessStatusCode) //Om anslutning inte upprättades eller om vi får en HTTP returkod som inte börjar med 2 anses länken ogiltig.
                { 
                    return false;
                }

                string content = await response.Content.ReadAsStringAsync(); //Hämtar innehåll från länken. ReadAsStringAsync gör det den heter lol.

                using (XmlReader reader = XmlReader.Create(new StringReader(content))) //Försöker att läsa in länken som en .xml och söker efter element som återfinns i RSS-flöden/element
                {
                    while (reader.Read() == true) //Läser igenom XML-dokumentet. Medans den "läser" är dess state satt till true. När den slutat "läsa" returneras false. 
                    { 

                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "rss") 
                        //Om XML-läsaren upptäcker ett XML-element, samt om elementet heter "rss" (ser ut såhär <rss>) lyckas valideringen! Yippie!
                        //reader.NodeType == XmlNodeType.Element kontrollerar specifikt efter XML tags, som <rss>. Det sparar på både resurser och tid då den skippar annat innehåll som kommentarer, text, attribut osv.
                        {
                            return true;
                        }

                    }
                }
                return false; //Returneras om den misslyckade att läsa in länken som en XML.
            }
            catch //Om det failar vid någon check returneras false.
            {
                return false;
            }
        }

        public bool isDuplicate(string name, string type)
        {
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type))
            {
                return false;
            }

            name = name.ToLower();
            type = type.ToLower();

            switch (type)
            {
                case "category":
                    return categoryController.GetAll().Any(category => category.Name.ToLower() == name);

                case "feed":
                    return feedController.GetFeeds().Any(feed => feed.Name.ToLower() == name);

                default:
                    return false;
            }
        }
    }
}
