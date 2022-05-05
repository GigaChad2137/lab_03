using System;
using System.IO;
namespace ConsoleApp.Logger
{
    public class FileLogger : WriterLogger
    {
        bool disposed;
        protected FileStream stream;
        string path;

        ~FileLogger()
        {
            this.Dispose();
        }

        public override void Dispose(bool disposing)
        {
            stream.Dispose();
            path = null;
            disposed = true;
        }

        public FileLogger(string path)
        {
            this.path = path;
        }
    }
}
