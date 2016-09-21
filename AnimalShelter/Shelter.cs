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
        private List<Owner> owners;

        public Shelter(string name)
        {
            Name = name;
            List<Pet> pets = new List<Pet>();
        }

        public string Name { get { return name; } set { name = value; } }

        public List<Pet> Pets { get { return pets; } set { pets = value; } }

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public void SellPet(string petName, int petAge, string ownerName, Owner owner)
        {
            int i = 0;
            foreach(Pet animal in Pets)
            {
                if(petName == animal.Name && petAge == animal.Age)
                {
                    Pets.RemoveAt(i);
                }
                i++;
            }
            owner.Pets.Add(Pets[i]);
        }
    }
}
