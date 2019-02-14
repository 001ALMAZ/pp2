using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void printInfo(FileSystemInfo di, int k)//трансефр на наш язык 
        {
            string s = new string('\t' , k);// капталга шыгарат 
            s += di.Name;
            Console.WriteLine(s);
            if (di.GetType() == typeof(DirectoryInfo))
            {
                var v = (di as DirectoryInfo).GetFileSystemInfos();//вар не менять данных 
                foreach (var i in v)//цикл для получение данных в файлач 
                {
                    printInfo(i, k + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\PP2");
            printInfo(di, 0);
            Console.ReadKey();
        }
    }
}