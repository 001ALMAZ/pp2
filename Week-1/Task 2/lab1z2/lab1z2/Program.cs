
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1z2
// делаем конструктор 
{
    class Program
    {
        class Student
        {
            string name; //создаем строка для имя 
            int id, year=1; // и еще ид и год
            public Student(string name, int id)  //чтобы вести имя и ид 
            {
                this.name = name;
                this.id = id;

            }
            public String aname() //тип функци
            {
                return name;
            }
            public int aid()
            {
                return id;
            }
            public int getYear()
            {
                return year;
            }
            public void ayear(int year)
            {

                ++year;
            }

        }

        static void Main(string[] args)
        {
            Student almaz = new Student("Almaz", 9);
            Console.WriteLine(almaz.aname());
            Console.WriteLine(almaz.getYear);
            almaz.ayear();
            Console.WriteLine(almaz.getYear());
            Student beka = new Student("BEKA", 10);
            Console.WriteLine(beka.aname());


            Console.ReadKey();

        }
    }
}