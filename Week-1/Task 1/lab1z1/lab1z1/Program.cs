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
            int N = int.Parse(Console.ReadLine ());
            List<int> ans = new List<int>();
            string[] arr = Console.ReadLine().Split();
            for( int i = 0; i < N; i++)
            {
                int a = int.Parse(arr[i]);
                int ok = 1;
                for (int j = 2; j <= (int)Math.Sqrt(a) && ok == 1; j++)
                    if (a % j == 0)
                        ok = 0;
                if (a != 1 && ok == 1)
                    ans.Add(a);
            }
            Console.WriteLine(ans.Count());
            for (int i = 0; i < ans.Count(); i++)
                Console.Write(ans[i] + " ");
            Console.ReadKey();
        }
    }
}