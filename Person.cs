using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Person
    {
        public string name;
            public string surname;
            public int age;
            public Person()
            { }


        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Андрей", "Мустяца", 17);
        }


        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
