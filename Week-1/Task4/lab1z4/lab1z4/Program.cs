using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1z4

{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());//создаем интеджер и вваодим числа 
            for (int i = 1; i <= N; i++) // пробек по вертикаль
            {
                for (int j = 1; j <= i; j++) //пробек по горизонт  
                {
                    Console.Write("[*]"); // вывод 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}