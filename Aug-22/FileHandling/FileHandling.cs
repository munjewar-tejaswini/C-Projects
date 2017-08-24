using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class FileHandling : IDisposable
    {
        private StreamReader reader;
        private StreamWriter writer;

        public void CreateFile()
        {
            writer = new StreamWriter(new FileStream(@"D:\Visual Studio Projects\Sample.txt", FileMode.Create));
        }

        public void WriteToFile()
        {
            if(writer !=null)
            {
                writer.WriteLine("This is the method WriteToFile");
                Console.WriteLine("Hello Everyone..");
                writer.Flush();
                writer.Close();
            }
            
        }

        public void ReadfromFile()
        {
            reader = new StreamReader(new FileStream(@"D:\Visual Studio Projects\Sample.txt", FileMode.Open));
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }

        public void Dispose()
        {
            Console.WriteLine("Inside Dispose");
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if(disposing)
            {
                GC.SuppressFinalize(this);
            }

            if(reader != null)
            {
                reader.Dispose();
                Console.WriteLine("Reader Disposed");
            }
        }
    }
}
