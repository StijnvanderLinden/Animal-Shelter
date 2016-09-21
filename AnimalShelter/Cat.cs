using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat : Pet
    {
        List<string> behavior;

        public Cat(string name, int age, bool reserved, List<string> behavior) : base(name, age, reserved)
        {
            Behavior = behavior;
            Name = name;
            Age = age;
            Reserved = reserved;
        }

        public List<string> Behavior { get { return behavior; } set { behavior = value; } }

        public void AddBehavior(string behavior)
        {
            Behavior.Add(behavior);
        }

        public void RemoveBehavior(string behavior)
        {
            int behaviorIndex = Behavior.IndexOf(behavior);
            Behavior.RemoveAt(behaviorIndex);
        }
    }
}
