using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ValidationSerializer
    {
        public bool DirectoryExists(string path)
        {
            return Directory.Exists(Path.GetDirectoryName(path));
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
