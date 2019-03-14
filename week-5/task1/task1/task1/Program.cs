using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace task1
{

    public class Complex
    {
        public int a;
        public int b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex() { }
        public void Ser()
        {
           
            FileStream fs = new FileStream("Complex.txt", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, this);
            fs.Close();
        }
        public Complex Des()
        {
            FileStream fs = new FileStream("Complex.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex res = xs.Deserialize(fs) as Complex;
            fs.Close();
            return res;
        }
        public String toString()
        {
            String res = a + "+" + b + "i";
            return res;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Complex c = new Complex(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            c.Ser();
            c.Des();
            Console.WriteLine(c.toString());
            Console.ReadKey();

        }
    }
}
