using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Shelter
    {
        public string Name { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Owner> Owners { get; set; }

        public Shelter(string name)
        {
            Name = name;
            Pets = new List<Pet>();
            Owners = new List<Owner>();
        }


        public void AddPet(Pet pet)
        {
            Pets.Add(pet);
        }

        public void SellPet(Pet pet, Owner owner)
        {
            Pets.Remove(pet);
            owner.Pets.Add(pet);
        }

        public void RemovePet(Pet pet)
        {
            Pets.Remove(pet);
        }

        public void WalkDog(Dog dog)
        {
            dog.LastWalk = DateTime.Now;
        }
    }
}