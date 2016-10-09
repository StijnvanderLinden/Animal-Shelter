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
        public List<Pet> Pets { get; set; }
        public List<Pet> ReservedPets { get; set; }
        public List<Product> Products { get; set; }

        public Owner(string name)
        {
            Name = name;
            Pets = new List<Pet>();
            ReservedPets = new List<Pet>();
            Products = new List<Product>();
        }
        public void ReservePet(Pet pet)
        {
            ReservedPets.Add(pet);
            pet.Reserved = true;
        }
    }
}
