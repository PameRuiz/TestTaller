using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace TestRazor.Common
{
    public static class Logger
    {
        public static void Log(string mensaje)
        {
            File.AppendAllText(@"C:\Users\Pamela\Desktop\TestTaller\ArchivoLog.txt",
                string.Format("{0} - INFO: {1}",DateTime.Now,
                mensaje + Environment.NewLine));
        }
    }
}