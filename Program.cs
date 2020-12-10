using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + " сегодня" + "[" + DateTime.Now + "]");
        }
    }
}
