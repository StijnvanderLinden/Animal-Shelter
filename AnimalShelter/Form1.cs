using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        Shelter shelter;
        public Form1()
        {
            InitializeComponent();
            shelter = new Shelter("Animal Shelter");
        }

        private void btAddPet_Click(object sender, EventArgs e)
        {
            if (rbDog.Checked)
            {
                Dog dog = new Dog(txtPetName.Text, Convert.ToInt32(txtPetAge.Text), false, DateTime.Now);
                shelter.Dogs.Add(dog);
            }
            else
            {
                Cat cat = new Cat(txtPetName.Text, Convert.ToInt32(txtPetAge.Text), false, txtCatBehavior.Text);
                shelter.Cats.Add(cat);
            }
            RefreshLists();
        }

        private void btAddOwner_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner(txtOwnerName.Text);
            shelter.Owners.Add(owner);
            RefreshLists();
        }

        private void btBuyPet_Click(object sender, EventArgs e)
        {
            shelter.SellPet(shelter.Pets[lbDogs.SelectedIndex], shelter.Owners[lbOwners.SelectedIndex]);
        }

        private void btRemovePet_Click(object sender, EventArgs e)
        {
            if(lbDogs.SelectedItem != null)
            {
                shelter.RemovePet(shelter.Pets[lbDogs.SelectedIndex]);
                RefreshLists();
            }
            else if(lbCats.SelectedItem != null)
            {
                shelter.
            }
        }
        private void btBuyDog_Click(object sender, EventArgs e)
        {
            shelter.Owners[lbOwners.SelectedIndex].Pets.Add(shelter.Pets[lbDogs.SelectedIndex]);
            shelter.Pets[lbDogs.SelectedIndex].Owner = shelter.Owners[lbOwners.SelectedIndex];
            lbOwnerPets.Items.Add(shelter.Pets[lbDogs.SelectedIndex].Name);
        }

        private void btReservePet_Click(object sender, EventArgs e)
        {
            shelter.Owners[lbOwners.SelectedIndex].ReservedPets.Add(shelter.Pets[lbDogs.SelectedIndex]);
            shelter.Pets[lbDogs.SelectedIndex].Reserved = true;
            lbReservedPets.Items.Add(shelter.Pets[lbDogs.SelectedIndex]);
        }

        private void btSellPet_Click(object sender, EventArgs e)
        {
            shelter.Owners[lbOwners.SelectedIndex].Pets.Remove(shelter.Pets[lbDogs.SelectedIndex]);
            shelter.Pets[lbDogs.SelectedIndex].Owner = null;
        }

        private void lbOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOwnerPets.Items.Clear();
            foreach(Pet pet in shelter.Owners[lbOwners.SelectedIndex].Pets)
            {
                lbOwnerPets.Items.Add(pet.Name);
            }

        }
        private void lbPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDogDetails.Items.Clear();
            lbDogDetails.Items.Add("Name: " + shelter.Pets[lbDogs.SelectedIndex].Name);
            lbDogDetails.Items.Add("Age: " + shelter.Pets[lbDogs.SelectedIndex].Age);
            lbDogDetails.Items.Add("Reserved: " + shelter.Pets[lbDogs.SelectedIndex].Reserved);
            if(shelter.Pets[lbDogs.SelectedIndex].Owner != null)
            {
                lbDogDetails.Items.Add("Owner: " + shelter.Pets[lbDogs.SelectedIndex].Owner.Name);
            }
            //if(shelter.Pets[lbPets.SelectedIndex].GetType() == typeof(Dog))
            //{
            //    lbPetDetails.Items.Add
            //}
        }
        private void RefreshLists()
        {
            lbDogs.Items.Clear();
            lbOwners.Items.Clear();
            lbOwnerPets.Items.Clear();
            foreach (Pet pet in shelter.Pets)
            {
                lbDogs.Items.Add(pet.Name);
            }

            foreach (Owner owner in shelter.Owners)
            {
                lbOwners.Items.Add(owner.Name);
            }
        }
    }
}