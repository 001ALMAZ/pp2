using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class FarManager
    {
        public int cursor, sz;//объявляем все переменный 
        public bool ok;
        public string path;
        DirectoryInfo di = null;
        FileSystemInfo fsi = null;
        public FarManager()
        {
            cursor = 0;//ен жогарда турат 
        }
        public FarManager(string path)//программа жасаугай керек заттын бары бар 
        {
            this.path = path;
            cursor = 0;
            di = new DirectoryInfo(path);
            sz = di.GetFileSystemInfos().Length;
            ok = true;
        }
        public void Color(FileSystemInfo fs, int index)//цвет  
        {
            if (cursor == index)//курсордын светы
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                fsi = fs; 
            }
            else if (fs.GetType() == typeof(DirectoryInfo))//папкылердын цветы
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else//калганынын цветы
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        public void Show()// меню корсететын метод  
        {
            Console.BackgroundColor = ConsoleColor.Black;//фон цвет
            Console.Clear();
            di = new DirectoryInfo(path);//путь
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)//цикл папкыге кыру ушн
            {
                if (ok == false && fs[i].Name[0] == '.') //
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);//кырген папкынын ышндегы аттарын шыгарп беред
                k++;
            }
        }
        public void Up()//курсордын движениесы 
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        public void CalcSz()//папкылердын быр бырмен тексеруы ушн
        {
            di = new DirectoryInfo(path);
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
            {
                for (int i = 0; i < fs.Length; i++)
                {
                    if (fs[i].Name[0] == '.')
                        sz--;
                }
            }
        }
        public void Start()
        {
            ConsoleKeyInfo conskey = Console.ReadKey();// 
            while (conskey.Key != ConsoleKey.Escape)//программадан шыгу ушн
            {
                CalcSz();
                Show();
                conskey = Console.ReadKey();
                if (conskey.Key == ConsoleKey.UpArrow) Up();
                if (conskey.Key == ConsoleKey.DownArrow) Down();
                if (conskey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (conskey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (conskey.Key == ConsoleKey.Enter)
                {
                    if (fsi.GetType() == typeof(DirectoryInfo))
                    {//папкагы кырген кезде курсор жогарыда турады
                        cursor = 0;
                        path = fsi.FullName;
                    }
                }
                if (conskey.Key == ConsoleKey.Backspace)//назад
                {
                    cursor = 0;
                    path = di.Parent.FullName;//начальный папканы кайтарад
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Алмаз/Desktop";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}