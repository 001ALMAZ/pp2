using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Создание и введение количества чисел
            List<int> ans = new List<int>(); // Создание вектора для хранения ответа
            string[] arr = Console.ReadLine().Split(); // Создание и введение чисел через пробел
            for (int i = 0; i < N; i++) // Обход всех чисел
            {
                int a = int.Parse(arr[i]);
                ans.Add(a); // Двойное добавление чисел для их повторения
                ans.Add(a);
            }

            for (int i = 0; i < ans.Count; i++) // Вывод ответа через пробел
                Console.Write(ans[i] + " ");
            Console.ReadKey(); // system("pause")
        }
    }
}