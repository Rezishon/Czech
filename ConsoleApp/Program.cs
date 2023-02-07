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
            Class1 class1 = new Class1();
            class1.Num = 1;
            Class1 class2 = class1;
            Console.WriteLine(class2.Num);
            class2.Num = 3;
            Console.WriteLine(class2.Num);
            Console.ReadKey();
        }
    }
}
//C:\Projects\Czech\Czech\ C:\Projects\Czech\ConsoleApp\
//C:\Projects\Czech\Czech\Resources\image.jpg
