using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Owner
    {
        private string name;
        private List<Pet> pets;
        private List<Pet> reservedPets;

        public Owner(string name, List<Pet> pets, List<Pet> reservedPets)
        {
            Name = name;
            Pets = pets;
            ReservedPets = reservedPets;
        }

        public string Name { get { return name; }  set { name = value; } }

        public List<Pet> Pets { get { return pets; } set { pets = value; } }

        public List<Pet> ReservedPets { get { return reservedPets; } set { reservedPets = value; } }

        public void ReservePet(Pet pet)
        {
            ReservedPets.Add(pet);
            pet.Reserved = true;
        }
    }
}
