using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Programm
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Ванёк", 3);
            st1.ShowInfo();
            Student st2 = new Student("", -7);
            st2.ShowInfo();
            Console.ReadKey();
        }
    }
}
