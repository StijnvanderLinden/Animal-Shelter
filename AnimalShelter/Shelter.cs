using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Shelter : ISortTest
    {
        public string Name { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }
        public List<Owner> Owners { get; set; }

        public Shelter(string name)
        {
            Name = name;
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
            Owners = new List<Owner>();
        }


        public void AddPet(Pet pet)
        {
            if(pet.GetType() == typeof(Dog))
            {
                Dogs.Add(pet);
            }
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

        public Pet 
    }
}