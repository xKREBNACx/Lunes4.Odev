using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverter
{
    class Program
    {      
        static void Main(string[] args)
        {
           
            object file = "Wanted Conversion File";

            var converters = new List<IFileConverter> { new Jpg2BmpConverter(), new Png2JpgConverter() };

            List<object> convertedFileList = new List<object>();

            foreach (var fileItem in converters)
            {
                convertedFileList.Add(fileItem.Convert(file));
            }
            foreach (var item in convertedFileList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
