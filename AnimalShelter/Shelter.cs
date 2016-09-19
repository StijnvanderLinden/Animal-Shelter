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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal List<Pet> Pets
        {
            get
            {
                return pets;
            }

            set
            {
                pets = value;
            }
        }

        public void AddPet(Pet pet)
        {

        }

        public void SellPet(Pet pet, Owner owner)
        {

        }
    }
}
