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
        Webshop webshop;
        public Form1()
        {
            InitializeComponent();
            shelter = new Shelter("Animal Shelter");
            webshop = new Webshop();
            webshop.Products.Add(new Product("Dog food", 15));
            webshop.Products.Add(new Product("Cat food", 10));
            RefreshLists();
        }

        private void btAddPet_Click(object sender, EventArgs e)
        {
            if (rbDog.Checked)
            {
                int price = 500;
                foreach (Dog doggy in shelter.Pets)
                {
                    if (price == 50)
                    {
                        break;
                    }
                    else
                    {
                        price -= 50;
                    }
                }
                Dog dog = new Dog(txtPetName.Text, price, Convert.ToInt32(txtPetAge.Text), false, DateTime.Now);
                shelter.Pets.Add(dog);
            }
            else
            {
                int price = 350;
                foreach (char character in txtCatBehavior.Text)
                {
                    if (price > 50)
                    {
                        price -= 20;
                    }
                    else
                    {
                        price = 35;
                        break;
                    }
                }
                Cat cat = new Cat(txtPetName.Text, price, Convert.ToInt32(txtPetAge.Text), false, txtCatBehavior.Text);
                shelter.Pets.Add(cat);
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
            shelter.SellPet(shelter.Pets[lbPets.SelectedIndex], shelter.Owners[lbOwners.SelectedIndex]);
        }

        private void btRemovePet_Click(object sender, EventArgs e)
        {
            if (lbPets.SelectedItem != null)
            {
                shelter.RemovePet(shelter.Pets[lbPets.SelectedIndex]);
                RefreshLists();
            }
        }
        private void btBuyDog_Click(object sender, EventArgs e)
        {
            shelter.Owners[lbOwners.SelectedIndex].Pets.Add(shelter.Pets[lbPets.SelectedIndex]);
            shelter.Pets[lbPets.SelectedIndex].Owner = shelter.Owners[lbOwners.SelectedIndex];
            lbOwnerPets.Items.Add(shelter.Pets[lbPets.SelectedIndex].Name);
        }

        private void btReservePet_Click(object sender, EventArgs e)
        {
            shelter.Owners[lbOwners.SelectedIndex].ReservedPets.Add(shelter.Pets[lbPets.SelectedIndex]);
            shelter.Pets[lbPets.SelectedIndex].Reserved = true;
            lbReservedPets.Items.Add(shelter.Pets[lbPets.SelectedIndex]);
        }

        private void btSellPet_Click(object sender, EventArgs e)
        {
            shelter.Owners[lbOwners.SelectedIndex].Pets.Remove(shelter.Pets[lbPets.SelectedIndex]);
            shelter.Pets[lbPets.SelectedIndex].Owner = null;
        }
        private void btAddProduct_Click(object sender, EventArgs e)
        {

        }
        private void btBuyProduct_Click(object sender, EventArgs e)
        {

        }
        private void lbOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOwnerPets.Items.Clear();
            lbReservedPets.Items.Clear();
            lbOwnerProducts.Items.Clear();
            foreach (Pet pet in shelter.Owners[lbOwners.SelectedIndex].Pets)
            {
                lbOwnerPets.Items.Add(pet.Name);
            }
            foreach (Pet pet in shelter.Owners[lbOwners.SelectedIndex].ReservedPets)
            {
                lbReservedPets.Items.Add(pet.Name);
            }
            foreach (Product product in shelter.Owners[lbOwners.SelectedIndex].Products)
            {
                lbOwnerProducts.Items.Add(product.Name);
            }
        }
        private void lbPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPetDetails.Items.Clear();
            lbPetDetails.Items.Add("Name: " + shelter.Pets[lbPets.SelectedIndex].Name);
            lbPetDetails.Items.Add("Age: " + shelter.Pets[lbPets.SelectedIndex].Age);
            lbPetDetails.Items.Add("Reserved: " + shelter.Pets[lbPets.SelectedIndex].Reserved);
            lbPetDetails.Items.Add("Price: €" + shelter.Pets[lbPets.SelectedIndex].Price);
            if (shelter.Pets[lbPets.SelectedIndex].Owner != null)
            {
                lbPetDetails.Items.Add("Owner: " + shelter.Pets[lbPets.SelectedIndex].Owner.Name);
            }
        }
        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RefreshLists()
        {
            lbPets.Items.Clear();
            lbOwners.Items.Clear();
            lbOwnerPets.Items.Clear();
            lbProducts.Items.Clear();
            foreach (Pet pet in shelter.Pets)
            {
                lbPets.Items.Add(pet.Name);
            }

            foreach (Owner owner in shelter.Owners)
            {
                lbOwners.Items.Add(owner.Name);
            }
            foreach (Product product in webshop.Products)
            {
                lbProducts.Items.Add(product.Name);
            }
        }
    }
}