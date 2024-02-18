using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Student
    {
        private string fam;
        private int kurs;

        public string Fam
        {
            get
            {
                return (fam != "") ? fam : "Неизвестный";
            }
            set
            {
                fam = value.ToUpper();
            }
        }

        public int Kurs
        {
            get
            {
                return kurs < 1 || kurs > 4 ? 0 : kurs;
            }
            set
            {
                kurs = value;
            }
        }

        public Student(string fam, int kurs)
        {
            this.Fam = fam;
            this.Kurs = kurs;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия:\t{Fam}\nКурс\t{Kurs}");
        }
    }
}
