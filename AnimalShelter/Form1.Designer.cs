namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbOwners = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPets = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPetDetails = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAddPet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btSellPet = new System.Windows.Forms.Button();
            this.lbOwnerPets = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.btReservePet = new System.Windows.Forms.Button();
            this.btBuyDog = new System.Windows.Forms.Button();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtPetAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbReservedPets = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.btAddOwner = new System.Windows.Forms.Button();
            this.txtCatBehavior = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btRemovePet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOwners
            // 
            this.lbOwners.FormattingEnabled = true;
            this.lbOwners.Location = new System.Drawing.Point(175, 247);
            this.lbOwners.Name = "lbOwners";
            this.lbOwners.Size = new System.Drawing.Size(111, 95);
            this.lbOwners.TabIndex = 0;
            this.lbOwners.SelectedIndexChanged += new System.EventHandler(this.lbOwners_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Animal Shelter";
            // 
            // lbPets
            // 
            this.lbPets.FormattingEnabled = true;
            this.lbPets.Location = new System.Drawing.Point(172, 75);
            this.lbPets.Name = "lbPets";
            this.lbPets.Size = new System.Drawing.Size(111, 95);
            this.lbPets.TabIndex = 3;
            this.lbPets.SelectedIndexChanged += new System.EventHandler(this.lbPets_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pets";
            // 
            // lbPetDetails
            // 
            this.lbPetDetails.FormattingEnabled = true;
            this.lbPetDetails.Location = new System.Drawing.Point(292, 75);
            this.lbPetDetails.Name = "lbPetDetails";
            this.lbPetDetails.Size = new System.Drawing.Size(111, 95);
            this.lbPetDetails.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pet Details";
            // 
            // btAddPet
            // 
            this.btAddPet.Location = new System.Drawing.Point(12, 233);
            this.btAddPet.Name = "btAddPet";
            this.btAddPet.Size = new System.Drawing.Size(75, 23);
            this.btAddPet.TabIndex = 9;
            this.btAddPet.Text = "Add pet";
            this.btAddPet.UseVisualStyleBackColor = true;
            this.btAddPet.Click += new System.EventHandler(this.btAddPet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Owner Pets";
            // 
            // btSellPet
            // 
            this.btSellPet.Location = new System.Drawing.Point(192, 377);
            this.btSellPet.Name = "btSellPet";
            this.btSellPet.Size = new System.Drawing.Size(75, 23);
            this.btSellPet.TabIndex = 12;
            this.btSellPet.Text = "Sell pet";
            this.btSellPet.UseVisualStyleBackColor = true;
            this.btSellPet.Click += new System.EventHandler(this.btSellPet_Click);
            // 
            // lbOwnerPets
            // 
            this.lbOwnerPets.FormattingEnabled = true;
            this.lbOwnerPets.Location = new System.Drawing.Point(292, 247);
            this.lbOwnerPets.Name = "lbOwnerPets";
            this.lbOwnerPets.Size = new System.Drawing.Size(111, 95);
            this.lbOwnerPets.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "New Pet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Age:";
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(12, 130);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(45, 17);
            this.rbDog.TabIndex = 17;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Dog";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(12, 153);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(41, 17);
            this.rbCat.TabIndex = 18;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "Cat";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // btReservePet
            // 
            this.btReservePet.Location = new System.Drawing.Point(192, 406);
            this.btReservePet.Name = "btReservePet";
            this.btReservePet.Size = new System.Drawing.Size(75, 23);
            this.btReservePet.TabIndex = 19;
            this.btReservePet.Text = "Reserve pet";
            this.btReservePet.UseVisualStyleBackColor = true;
            this.btReservePet.Click += new System.EventHandler(this.btReservePet_Click);
            // 
            // btBuyDog
            // 
            this.btBuyDog.Location = new System.Drawing.Point(192, 348);
            this.btBuyDog.Name = "btBuyDog";
            this.btBuyDog.Size = new System.Drawing.Size(75, 23);
            this.btBuyDog.TabIndex = 20;
            this.btBuyDog.Text = "Buy pet";
            this.btBuyDog.UseVisualStyleBackColor = true;
            this.btBuyDog.Click += new System.EventHandler(this.btBuyDog_Click);
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(56, 78);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(79, 20);
            this.txtPetName.TabIndex = 21;
            // 
            // txtPetAge
            // 
            this.txtPetAge.Location = new System.Drawing.Point(56, 104);
            this.txtPetAge.Name = "txtPetAge";
            this.txtPetAge.Size = new System.Drawing.Size(34, 20);
            this.txtPetAge.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "New Owner";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Reserved pets";
            // 
            // lbReservedPets
            // 
            this.lbReservedPets.FormattingEnabled = true;
            this.lbReservedPets.Location = new System.Drawing.Point(409, 247);
            this.lbReservedPets.Name = "lbReservedPets";
            this.lbReservedPets.Size = new System.Drawing.Size(111, 95);
            this.lbReservedPets.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Name:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(59, 296);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(79, 20);
            this.txtOwnerName.TabIndex = 27;
            // 
            // btAddOwner
            // 
            this.btAddOwner.Location = new System.Drawing.Point(15, 322);
            this.btAddOwner.Name = "btAddOwner";
            this.btAddOwner.Size = new System.Drawing.Size(75, 23);
            this.btAddOwner.TabIndex = 28;
            this.btAddOwner.Text = "Add owner";
            this.btAddOwner.UseVisualStyleBackColor = true;
            this.btAddOwner.Click += new System.EventHandler(this.btAddOwner_Click);
            // 
            // txtCatBehavior
            // 
            this.txtCatBehavior.Location = new System.Drawing.Point(12, 192);
            this.txtCatBehavior.Name = "txtCatBehavior";
            this.txtCatBehavior.Size = new System.Drawing.Size(123, 20);
            this.txtCatBehavior.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Cat behavior:";
            // 
            // btRemovePet
            // 
            this.btRemovePet.Location = new System.Drawing.Point(192, 176);
            this.btRemovePet.Name = "btRemovePet";
            this.btRemovePet.Size = new System.Drawing.Size(75, 23);
            this.btRemovePet.TabIndex = 31;
            this.btRemovePet.Text = "Remove pet";
            this.btRemovePet.UseVisualStyleBackColor = true;
            this.btRemovePet.Click += new System.EventHandler(this.btRemovePet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 446);
            this.Controls.Add(this.btRemovePet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCatBehavior);
            this.Controls.Add(this.btAddOwner);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbReservedPets);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPetAge);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.btBuyDog);
            this.Controls.Add(this.btReservePet);
            this.Controls.Add(this.rbCat);
            this.Controls.Add(this.rbDog);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOwnerPets);
            this.Controls.Add(this.btSellPet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btAddPet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPetDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOwners);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOwners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPetDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAddPet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSellPet;
        private System.Windows.Forms.ListBox lbOwnerPets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.Button btReservePet;
        private System.Windows.Forms.Button btBuyDog;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtPetAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbReservedPets;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Button btAddOwner;
        private System.Windows.Forms.TextBox txtCatBehavior;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btRemovePet;
    }
}

