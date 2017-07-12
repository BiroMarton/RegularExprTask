using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegularExprTask
{
    class Program
    {

        static string Matching(string text) {
            Match m = Regex.Match(text,@"^(\d{4}).(\d{2}).(\d{2})");
            return String.Format("{0}.{1}.{2} , ", m.Groups[1], m.Groups[2], m.Groups[3]);
        }

        static void Main(string[] args)
        {
            
            string result = "";
            Regex regex = new Regex(@"^\d{4}.\d{2}.\d{2}");
            string[] text = System.IO.File.ReadAllLines("WindowsUpdate.log");
            foreach (string line in text) {


                result += Matching(line);
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
