using System;

namespace task4
{
    public class Parametr
    {
        public int number;
        public string str;
        public void DoSomething()
        {
            Console.WriteLine($"Число = {number} Строчка = {str}");
        }
        public void DoSomething1()
        {
            Console.WriteLine("123");
        }
        public Parametr() { number = 55; str = "Иди сюда"; }

        public Parametr(string stroka) { number = 1222; str = stroka; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Parametr One = new Parametr();
            Parametr Two = new Parametr("привет Ден");
            One.DoSomething();
            One.DoSomething();
            Two.DoSomething1();
        }
    }
}