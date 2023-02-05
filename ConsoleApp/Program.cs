using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\Resources\\image.jpg";
            Console.WriteLine(path);
            Console.ReadKey();

        }
    }
}
//C:\Projects\Czech\Czech\ C:\Projects\Czech\ConsoleApp\
//C:\Projects\Czech\Czech\Resources\image.jpg
