using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog : Pet
    {
        private DateTime lastWalk;

        public Dog(string name, int age, bool reserved, DateTime lastWalk) : base(name, age, reserved)
        {
            LastWalk = lastWalk;
        }

        public DateTime LastWalk { get { return lastWalk; } set { lastWalk = value; } }
        public void WalkDog(Dog dog)
        {
            LastWalk = DateTime.Now;
        }
    }
}
