using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog : Pet
    {

        public DateTime LastWalk { get; set; }

        public Dog(string name, int age, bool reserved, DateTime lastWalk) : base(name, age, reserved)
        {
            LastWalk = lastWalk;
            Name = name;
            Age = age;
            Reserved = reserved;
        }
        public override string MakeNoise()
        {
            return "Woof";
        }
    }
}
