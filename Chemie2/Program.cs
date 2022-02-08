using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemie2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int b = 1;
            while (b==1)
            {
                Console.WriteLine("Chcete zadat vzorec(v) nebo název(n) nebo ukončit program(esc)");
                string que = Console.ReadLine();

                var application = new App();
                if (que == "v")
                {
                    Console.WriteLine(application.WriteIN());
                }
                if (que == "n")
                {
                    Console.WriteLine(application.WriteOUT());
                }
                if (que == "esc")
                {
                    b = 2;
                }
            }
            
        }
    }
}
