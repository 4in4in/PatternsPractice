using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Log
    {
        static Log myLog = null;
        //staticLazy<Log> myLog = newLazy<Log>(() => newLog());
        private Log() { }

        public static Log MyLog
        {
            get
            {
                if (myLog == null)
                {
                    myLog = new Log();
                }
                return myLog;
            }
        }

        //public static Log MyLog
        //{
        //    get { return myLog.Value; }
        //}
        public void logExecution(string msg)
        {
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                logger(msg, writer);
                writer.Close();
            }
        }

        private static void logger(string logMsg, TextWriter writer)
        {
            writer.Write("\r\nLog Entry : ");

            writer.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            writer.WriteLine("Действие: {0}", logMsg);
            writer.WriteLine("- - - - - - - - - -");
        }
    }
}
