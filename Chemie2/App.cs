using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemie2
{
    public class App
    {
        public string WriteIN()
        {

            StreamReader input = new StreamReader("input2.txt");
            string input1 = input.ReadLine();
            string[] inp = input1.Split(',');
            string inn = Console.ReadLine();
            string output = "Není v databázi";
            List<string> názvy = new List<string>();
            List<string> vzorce = new List<string>();
            for (int i = 0; i < inp.Length - 1; i++)
            {
                názvy.Add(inp[i]);
                if (i <= 0)
                {

                    vzorce.Add(inp[1]);
                }
                else { vzorce.Add(inp[i + 1]); }
                i = i + 1;
            }
            for (int i = 0; i < vzorce.Count; i++)
            {
                if (vzorce[i] == inn) { output = názvy[i]; }

            }
            return output;
        }
        public string WriteOUT()
        {
            StreamReader input = new StreamReader("input2.txt");
            string input1 = input.ReadLine();
            string[] inp = input1.Split(',');
            string inn = Console.ReadLine();
            string output = "Není v databázi";
            List<string> názvy = new List<string>();
            List<string> vzorce = new List<string>();
            for (int i = 0; i < inp.Length -1; i++)
            {
                názvy.Add(inp[i]);
                if (i <= 0)
                {

                    vzorce.Add(inp[1]);
                }
                else  { vzorce.Add(inp[i + 1]); }
                i=i + 1;
            }
            for (int i = 0; i < vzorce.Count; i++)
            {
                if (názvy[i] == inn) { output = vzorce[i]; }

            }
            return output;
        }
    }
}
