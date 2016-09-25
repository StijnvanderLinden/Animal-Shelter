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
                shelter.Pets.Add(dog);
            }
            else
            {
                Cat cat = new Cat(txtPetName.Text, Convert.ToInt32(txtPetAge.Text), false, txtCatBehavior.Text);
                shelter.Pets.Add(cat);
            }
            lbPets.Items.Clear();
            foreach(Pet pet in shelter.Pets)
            {
                lbPets.Items.Add(pet.Name);
            }
        }

        private void btAddOwner_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner(txtOwnerName.Text);
            shelter.Owners.Add(owner);
            lbOwners.Items.Clear();
            foreach (Owner owner1 in shelter.Owners)
            {
                lbOwners.Items.Add(owner1.Name);
            }
            
        }

        private void btBuyPet_Click(object sender, EventArgs e)
        {
            shelter.SellPet(shelter.Pets[lbPets.SelectedIndex], shelter.Owners[lbOwners.SelectedIndex]);
        }

        private void btRemovePet_Click(object sender, EventArgs e)
        {
            shelter.RemovePet(shelter.Pets[lbPets.SelectedIndex]);
        }
    }
}