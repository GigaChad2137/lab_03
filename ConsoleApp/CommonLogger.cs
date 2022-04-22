using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Logger;
using ConsoleApp;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApp.Logger
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;
        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }
        public virtual void Log(params String[] messages)
        {
            
        }
        public void Dispose(bool disposing)
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }


    }
}
