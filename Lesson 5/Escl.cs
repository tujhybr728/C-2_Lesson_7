using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Escl // позжу будет использоваться в массиве и выводе информации
    {
        public string Name { get; set; }
        public string Depart { get; set; }

        public Escl(string name, string dep)
        {
            Name = name;
            Depart = dep;
        }

    }
}
