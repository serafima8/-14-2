using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyClass
    {
        /// <summary>
        /// создание внутреннего нестатическое поля вещественного типа с именем value1
        /// </summary>
        private double value1;
        /// <summary>
        /// создание внутреннего нестатическое поля вещественного типа с именем value2
        /// </summary>
        private double value2;

        /// <summary>
        /// открытое целочисленное статическое поле с именем count для подсчета созданных экземпляров класса;
        /// </summary>
        public static int count;

        /// <summary>
        /// свойства для доступа к внутренним полям класса
        /// </summary>
        public double Value1
        { get { return value1; } set { value1 = value; } }

        public double Value2
        { get { return value2; } set { value2 = value; } }

        /// <summary>
        /// конструктор с парпаметрами 
        ///</summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public MyClass(double value1, double value2)
        {
            this.Value1 = value1; // this - ссылается на текущий экземпляр класса, а также используется в качестве модификатора первого параметра метода расширения
            this.Value2 = value2;
            count++;
        }

        /// <summary>
        /// Нестатический конструктор - инициализирует нестатические поля класса
        /// </summary>
        public MyClass()
        {
            value1 = value2 = 2.0;
            count++; //участвует в качеситве счетчика 
        }

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static MyClass()
        {
            count = 0;
        }

        /// <summary>
        /// Метод, который выводит информауию
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Поле 1: {value1}\tПоле 2: {value2}");
        }


    }
}
