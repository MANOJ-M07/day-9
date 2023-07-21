using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDisposableExample
{
    public class FileHandeler : IDisposable 
    {
        File fileObject=null;
        static int totalFiles =0;
        bool disposedvalue;
        public FileHandeler(string fileName)
        {
            if(fileObject==null)
            {
                totalFiles++;
                fileObject = new File(fileName);
            }
            Console.WriteLine("File Created");
            Console.WriteLine("Number of files are :"+totalFiles);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedvalue)
            {
                if (disposing)
                {
                    totalFiles = 0;
                }
                Console.WriteLine("file {0} has been disposed",fileObject.Name);
                fileObject = null;
                disposedvalue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing :true);
            GC.SuppressFinalize(this);

        }
        public void GetFileDetails()
        {
            Console.WriteLine(fileObject.Name+"file has been created sucessfully");
        }
        ~FileHandeler()
        {
            Dispose(false);
        }

    }
}
