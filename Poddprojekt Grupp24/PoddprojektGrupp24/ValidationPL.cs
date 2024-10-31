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

        public ValidationPL(string path)
        {
            feedController = new FeedController(path);
            categoryController = new CategeoryController();
        }
        public bool ValidationURL(string url)

        {
            string URLValid = string.Empty;
            Encoding enc = Encoding.ASCII;
            WebClient obj = new();
            URLValid = enc.GetString(obj.DownloadData(url));
            return URLValid.Length != 0 ? true : false;
        }
    }
}
