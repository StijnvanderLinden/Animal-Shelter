using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Owner
    {
        public string Name { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }
        public List<Pet> ReservedPets { get; set; }

        public Owner(string name)
        {
            Name = name;
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
            ReservedPets = new List<Pet>();
        }
        public void ReservePet(Pet pet)
        {
            ReservedPets.Add(pet);
            pet.Reserved = true;
        }
    }
}
