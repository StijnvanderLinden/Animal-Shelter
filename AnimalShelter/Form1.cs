﻿using System;
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
            if(lbPets.SelectedItem != null)
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
            lbPetDetails.Items.Add("Owner: " + shelter.Owners[lbOwners.SelectedIndex].Name);
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
            lbPetDetails.Items.Clear();
            lbPetDetails.Items.Add("Name: " + shelter.Pets[lbPets.SelectedIndex].Name);
            lbPetDetails.Items.Add("Age: " + shelter.Pets[lbPets.SelectedIndex].Age);
            lbPetDetails.Items.Add("Reserved: " + shelter.Pets[lbPets.SelectedIndex].Reserved);
            if(shelter.Pets[lbPets.SelectedIndex].Owner != null)
            {
                lbPetDetails.Items.Add("Owner: " + shelter.Pets[lbPets.SelectedIndex].Owner.Name);
            }
            //if(shelter.Pets[lbPets.SelectedIndex].GetType() == typeof(Dog))
            //{
            //    lbPetDetails.Items.Add
            //}
        }
        private void RefreshLists()
        {
            lbPets.Items.Clear();
            lbOwners.Items.Clear();
            lbOwnerPets.Items.Clear();
            foreach (Pet pet in shelter.Pets)
            {
                lbPets.Items.Add(pet.Name);
            }

            foreach (Owner owner in shelter.Owners)
            {
                lbOwners.Items.Add(owner.Name);
            }
        }
    }
}