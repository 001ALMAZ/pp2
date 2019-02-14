using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine ()); //количество чисол енгызу 
            List<int> ans = new List<int>(); //вектор для хранение ответа 
            string[] arr = Console.ReadLine().Split();//создание и ввод чисел чрез пробел  
            for( int i = 0; i < N; i++)//создаем цикел каждого проверит 
            {
                int a = int.Parse(arr[i]);
                int ok = 1;//типа булиан 
                for (int j = 2; j <= (int)Math.Sqrt(a) && ok == 1; j++)//пока бул 1 цикл работает
                    if (a % j == 0)
                        ok = 0;
                if (a != 1 && ok == 1) //создаем условия  
                    ans.Add(a);
            }
            Console.WriteLine(ans.Count()); //вывд количество простых чисел 
            for (int i = 0; i < ans.Count(); i++)
                Console.Write(ans[i] + " ");// цыкла выводит все простые числи через пробел 
            Console.ReadKey();// чтобы остановить консоль 
        }
    }
}