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

        }
    }
}
