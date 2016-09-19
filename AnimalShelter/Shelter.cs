using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Shelter
    {
        private string name;
        private List<Pet> pets;

        public Shelter(string name, List<Pet> pets)
        {
            Name = name;
            Pets = pets;
        }

        public string Name { get { return name; } set { name = value; } }

        public List<Pet> Pets { get { return pets; } set { pets = value; } }

        public void AddPet(string name, int age)
        {
            Pet pet = new Pet(name, age, false);
        }

        public void SellPet(Pet pet, Owner owner)
        {
            int i = 0;
            foreach(Pet animal in Pets)
            {
                if(pet.Name == animal.Name && pet.Age == animal.Age)
                {
                    Pets.RemoveAt(i);
                }
                i++;
            }
            owner.Pets.Add(pet);
        }
    }
}
