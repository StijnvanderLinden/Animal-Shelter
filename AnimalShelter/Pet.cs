using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Pet
    {
        private string name;
        private int age;
        private bool reserved;

        public Pet(string name, int age, bool reserved)
        {
            Name = name;
            Age = age;
            Reserved = reserved;
        }

        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }

        public bool Reserved { get { return reserved; } set { reserved = value; } }
    }
}
