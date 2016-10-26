using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace DisplayFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Please enter a valid filename e.g. >DisplayFile sample.txt");
                return;
            }
            string[] lines = File.ReadAllLines(args[0]);
            foreach(String item in lines)
            {
                Console.WriteLine(item);
            }
        }
    }
}
