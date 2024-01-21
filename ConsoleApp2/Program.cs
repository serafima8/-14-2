using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            MyClass myClass = new MyClass();
            myClass.Value1 = 9.8;
            myClass.Value2 = 4.1;
            Console.WriteLine($"Кол-во созданных экземпляров: {MyClass.count}");

            Console.ReadKey();


        }
    }
}
