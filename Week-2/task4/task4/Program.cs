using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем тхт файл для проверки 
            string s = "test.txt";
            //создан файл
            var c = File.Create("C:/PP2/Week-2/task4/create/" + s);
            c.Close();
            //Console.ReadKey();
            //копируем первый файл и уд его 
            File.Copy("C:/PP2/Week-2/task4/create/" + s, "C:/PP2/Week-2/task4/copy/" + s);
            File.Delete("C:/PP2/Week-2/task4/create/" + s);
        }
    }
}
