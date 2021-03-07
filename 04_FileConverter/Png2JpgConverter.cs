using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverter
{
    class Png2JpgConverter : IFileConverter
    {
        public string InputFileFormat => "png";

        public string OutputFileFormat => "jpg";

        public object Convert(object input) => " png file converted to jpg";
        
    }
}
