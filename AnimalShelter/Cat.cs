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

        public Cat(string name, decimal price, int age, bool reserved, string behavior) : base(name, price, age, reserved)
        {
            Behavior = behavior;
            Name = name;
            Price = price;
            Age = age;
            Reserved = reserved;
        }

        public override string MakeNoise()
        {
            return "Meow";
        }
    }
}
