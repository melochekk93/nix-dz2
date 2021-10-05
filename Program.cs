using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(ConfigurationManager.AppSettings.Get("File"));
            

            Console.ReadLine();
        }
    }
}
