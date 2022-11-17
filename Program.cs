using System;
using System.IO;
using System.Globalization;

namespace EsercizioLogFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            log.logger()
;        }
    }
    public static class log {
        public static DirectoryInfo Path = Path ;
        public static string message="ciao!!";
        public static DateTime curentData = DateTime.Now;
        public static string myDirectory = Directory.GetCurrentDirectory();

        public static void logger() {

            //File.Create();
            Console.WriteLine($"{message} hai aperto la cartella X alle {curentData}");
        }

        
    }
}
