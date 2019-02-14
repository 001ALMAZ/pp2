using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");//читалка данных
            string[] s = sr.ReadToEnd().Split();//ср до конца  прочитает и сплит чтоб пробел и клоз
            sr.Close();
            List<int> ans = new List<int>();// создаем вектор для хран данных
            for (int it = 0; it < s.Count(); it++)//пробек до стринге 
            {
                int a = int.Parse(s[it]); //ПАРС для трансвфер стринга на интеджер 
                int prime = 1;//болиен 
                for (int i = 2; i <= (int)Math.Sqrt(a) && prime == 1; i++)
                    if (a % i == 0)
                        prime = 0;
                if (a != 1 && prime == 1)
                    ans.Add(a);
            }
            StreamWriter sw = new StreamWriter("output.txt");//система сома пишет вывод 
            for (int i = 0; i < ans.Count(); i++)//пробежка по прайм числам 
                sw.Write(ans[i] + " ");// вывод данных
            sw.Close();
            Console.ReadKey();
        }
    }
}
