using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Build
    {
        public string name;
        public double area;
        public int kvo;
        public Build()
        {

        }
        public Build(string name, double area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }
        static void ShowInfo(string[] args)
        {
            Build build1 = new Build();
            Build build2 = new Build("Частный дом", 145, 4);
        }
    }
}
