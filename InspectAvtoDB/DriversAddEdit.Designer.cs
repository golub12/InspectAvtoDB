﻿
namespace InspectAvtoDB
{
    partial class DriversAddEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addresLabel;
            System.Windows.Forms.Label adressLifeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label descripLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label jobNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label postLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addresTextBox = new System.Windows.Forms.TextBox();
            this.adressLifeTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.descripTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            addresLabel = new System.Windows.Forms.Label();
            adressLifeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            descripLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            jobNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 66);
            this.panel2.TabIndex = 5;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(InspectAvtoDB.Drivers);
            // 
            // addresLabel
            // 
            addresLabel.AutoSize = true;
            addresLabel.Location = new System.Drawing.Point(28, 105);
            addresLabel.Name = "addresLabel";
            addresLabel.Size = new System.Drawing.Size(43, 13);
            addresLabel.TabIndex = 6;
            addresLabel.Text = "Addres:";
            // 
            // addresTextBox
            // 
            this.addresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Addres", true));
            this.addresTextBox.Location = new System.Drawing.Point(96, 102);
            this.addresTextBox.Name = "addresTextBox";
            this.addresTextBox.Size = new System.Drawing.Size(100, 20);
            this.addresTextBox.TabIndex = 7;
            // 
            // adressLifeLabel
            // 
            adressLifeLabel.AutoSize = true;
            adressLifeLabel.Location = new System.Drawing.Point(28, 131);
            adressLifeLabel.Name = "adressLifeLabel";
            adressLifeLabel.Size = new System.Drawing.Size(62, 13);
            adressLifeLabel.TabIndex = 8;
            adressLifeLabel.Text = "Adress Life:";
            // 
            // adressLifeTextBox
            // 
            this.adressLifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "AdressLife", true));
            this.adressLifeTextBox.Location = new System.Drawing.Point(96, 128);
            this.adressLifeTextBox.Name = "adressLifeTextBox";
            this.adressLifeTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressLifeTextBox.TabIndex = 9;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(360, 101);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 10;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(428, 98);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 11;
            // 
            // descripLabel
            // 
            descripLabel.AutoSize = true;
            descripLabel.Location = new System.Drawing.Point(360, 127);
            descripLabel.Name = "descripLabel";
            descripLabel.Size = new System.Drawing.Size(46, 13);
            descripLabel.TabIndex = 12;
            descripLabel.Text = "Descrip:";
            // 
            // descripTextBox
            // 
            this.descripTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Descrip", true));
            this.descripTextBox.Location = new System.Drawing.Point(428, 124);
            this.descripTextBox.Name = "descripTextBox";
            this.descripTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(731, 111);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(799, 108);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(731, 137);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 16;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(799, 134);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(28, 226);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 18;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(96, 223);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 19;
            // 
            // jobNameLabel
            // 
            jobNameLabel.AutoSize = true;
            jobNameLabel.Location = new System.Drawing.Point(28, 252);
            jobNameLabel.Name = "jobNameLabel";
            jobNameLabel.Size = new System.Drawing.Size(58, 13);
            jobNameLabel.TabIndex = 20;
            jobNameLabel.Text = "Job Name:";
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "JobName", true));
            this.jobNameTextBox.Location = new System.Drawing.Point(96, 249);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobNameTextBox.TabIndex = 21;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(360, 229);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(428, 226);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(360, 255);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(428, 252);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 25;
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(731, 232);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(51, 13);
            passportLabel.TabIndex = 26;
            passportLabel.Text = "Passport:";
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(799, 229);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportTextBox.TabIndex = 27;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(731, 258);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 28;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(799, 255);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 29;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(360, 345);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 30;
            photoLabel.Text = "Photo:";
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(428, 342);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(100, 20);
            this.photoTextBox.TabIndex = 31;
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.Location = new System.Drawing.Point(360, 371);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(31, 13);
            postLabel.TabIndex = 32;
            postLabel.Text = "Post:";
            // 
            // postTextBox
            // 
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Post", true));
            this.postTextBox.Location = new System.Drawing.Point(428, 368);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(100, 20);
            this.postTextBox.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(271, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 47);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DriversAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(addresLabel);
            this.Controls.Add(this.addresTextBox);
            this.Controls.Add(adressLifeLabel);
            this.Controls.Add(this.adressLifeTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(descripLabel);
            this.Controls.Add(this.descripTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(jobNameLabel);
            this.Controls.Add(this.jobNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(postLabel);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "DriversAddEdit";
            this.Text = "DriversAddEdit";
            this.Load += new System.EventHandler(this.DriversAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.TextBox addresTextBox;
        private System.Windows.Forms.TextBox adressLifeTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox descripTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button button2;
    }
}