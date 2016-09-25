using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat : Pet
    {
        public string Behavior { get; set; }

        public Cat(string name, int age, bool reserved, string behavior) : base(name, age, reserved)
        {
            Behavior = behavior;
            Name = name;
            Age = age;
            Reserved = reserved;
        }
    }
}
