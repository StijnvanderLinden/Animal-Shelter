using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Reserved { get; set; }

        public Pet(string name, int age, bool reserved)
        {
            Name = name;
            Age = age;
            Reserved = reserved;
        }
    }
}
