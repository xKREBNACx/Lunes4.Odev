using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverter
{
    public class Jpg2BmpConverter : IFileConverter
    {
        public string InputFileFormat => "jpg";

        public string OutputFileFormat => "bmp";

        public object Convert(object input) => "jpg file converted to bmp";
       
    }
}
