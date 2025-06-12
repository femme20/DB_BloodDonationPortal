namespace DBProject
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
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.btnViewDonors = new System.Windows.Forms.Button();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttxtname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.textage = new System.Windows.Forms.TextBox();
            this.ttxtblood = new System.Windows.Forms.TextBox();
            this.ttxtgender = new System.Windows.Forms.TextBox();
            this.ttxtphone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.Label();
            this.ttxtemail = new System.Windows.Forms.TextBox();
            this.ttxtcity = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpLastDonationDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(12, 466);
            this.dgvDonors.MultiSelect = false;
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowHeadersWidth = 62;
            this.dgvDonors.RowTemplate.Height = 28;
            this.dgvDonors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonors.Size = new System.Drawing.Size(1812, 206);
            this.dgvDonors.TabIndex = 0;
            // 
            // btnViewDonors
            // 
            this.btnViewDonors.Location = new System.Drawing.Point(242, 410);
            this.btnViewDonors.Name = "btnViewDonors";
            this.btnViewDonors.Size = new System.Drawing.Size(145, 35);
            this.btnViewDonors.TabIndex = 2;
            this.btnViewDonors.Text = "View Donors";
            this.btnViewDonors.UseVisualStyleBackColor = true;
            this.btnViewDonors.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(26, 410);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(147, 35);
            this.btnAddDonor.TabIndex = 3;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.Location = new System.Drawing.Point(461, 410);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(145, 35);
            this.btnUpdateDonor.TabIndex = 4;
            this.btnUpdateDonor.Text = "Update Donor";
            this.btnUpdateDonor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Location = new System.Drawing.Point(678, 410);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(139, 35);
            this.btnDeleteDonor.TabIndex = 5;
            this.btnDeleteDonor.Text = "Delete Donor";
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(743, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Donor Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ttxtname
            // 
            this.ttxtname.Location = new System.Drawing.Point(154, 135);
            this.ttxtname.Name = "ttxtname";
            this.ttxtname.Size = new System.Drawing.Size(120, 26);
            this.ttxtname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(48, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(48, 171);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(51, 20);
            this.txtAge.TabIndex = 9;
            this.txtAge.Text = "Age";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(48, 204);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(85, 23);
            this.txtGender.TabIndex = 10;
            this.txtGender.Text = "Gender";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(48, 241);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(135, 23);
            this.txtBloodGroup.TabIndex = 11;
            this.txtBloodGroup.Text = "Blood Group";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(49, 271);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(85, 26);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Text = "Phone";
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(156, 167);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(120, 26);
            this.textage.TabIndex = 13;
            this.textage.TextChanged += new System.EventHandler(this.ttxtage_TextChanged);
            // 
            // ttxtblood
            // 
            this.ttxtblood.Location = new System.Drawing.Point(156, 233);
            this.ttxtblood.Name = "ttxtblood";
            this.ttxtblood.Size = new System.Drawing.Size(120, 26);
            this.ttxtblood.TabIndex = 14;
            // 
            // ttxtgender
            // 
            this.ttxtgender.Location = new System.Drawing.Point(156, 201);
            this.ttxtgender.Name = "ttxtgender";
            this.ttxtgender.Size = new System.Drawing.Size(120, 26);
            this.ttxtgender.TabIndex = 15;
            // 
            // ttxtphone
            // 
            this.ttxtphone.Location = new System.Drawing.Point(156, 270);
            this.ttxtphone.Name = "ttxtphone";
            this.ttxtphone.Size = new System.Drawing.Size(120, 26);
            this.ttxtphone.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(47, 337);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(101, 23);
            this.txtCity.TabIndex = 18;
            this.txtCity.Text = "City";
            // 
            // ttxtemail
            // 
            this.ttxtemail.Location = new System.Drawing.Point(156, 301);
            this.ttxtemail.Name = "ttxtemail";
            this.ttxtemail.Size = new System.Drawing.Size(120, 26);
            this.ttxtemail.TabIndex = 19;
            // 
            // ttxtcity
            // 
            this.ttxtcity.Location = new System.Drawing.Point(156, 334);
            this.ttxtcity.Name = "ttxtcity";
            this.ttxtcity.Size = new System.Drawing.Size(120, 26);
            this.ttxtcity.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dtpLastDonationDate
            // 
            this.dtpLastDonationDate.Location = new System.Drawing.Point(47, 371);
            this.dtpLastDonationDate.Name = "dtpLastDonationDate";
            this.dtpLastDonationDate.Size = new System.Drawing.Size(179, 25);
            this.dtpLastDonationDate.TabIndex = 22;
            this.dtpLastDonationDate.Text = "Last Donation Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1846, 653);
            this.Controls.Add(this.dtpLastDonationDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ttxtcity);
            this.Controls.Add(this.ttxtemail);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.ttxtphone);
            this.Controls.Add(this.ttxtgender);
            this.Controls.Add(this.ttxtblood);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ttxtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.btnUpdateDonor);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.btnViewDonors);
            this.Controls.Add(this.dgvDonors);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Button btnViewDonors;
        private System.Windows.Forms.Button btnAddDonor;
        private System.Windows.Forms.Button btnUpdateDonor;
        private System.Windows.Forms.Button btnDeleteDonor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttxtname;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAge;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.Label txtBloodGroup;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.TextBox ttxtblood;
        private System.Windows.Forms.TextBox ttxtgender;
        private System.Windows.Forms.TextBox ttxtphone;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.TextBox ttxtemail;
        private System.Windows.Forms.TextBox ttxtcity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dtpLastDonationDate;
    }
}

