using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    abstract class Pet : ISellable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Age { get; set; }
        public bool Reserved { get; set; }
        public Owner Owner { get; set; }
        public Pet(string name, decimal price, int age, bool reserved)
        {
            Name = name;
            Price = price;
            Age = age;
            Reserved = reserved;
            Owner = null;
        }

        public abstract string MakeNoise();
    }
}
