using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//создаем и вволим стринговый данных
            bool check = true;
            for (int i = 0; i < s.Length && check == true; i++)//пробежка по стрингам 
                if (s[s.Length - i - 1] != s[i])//условия сравнивать 1 и послед букву  
                    check = false;
            if (check == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}