﻿namespace Client.View
{
    partial class AdminPanel2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewComitee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAddedChairs = new System.Windows.Forms.DataGridView();
            this.buttonAddChair = new System.Windows.Forms.Button();
            this.buttonRemoveChair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAddedPCMembers = new System.Windows.Forms.DataGridView();
            this.buttonAddPCMember = new System.Windows.Forms.Button();
            this.buttonRemovePCMember = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxConferenceEdition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxConferenceWebsite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxConferenceCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxConferenceCountry = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxConferenceName = new System.Windows.Forms.TextBox();
            this.addTopicsButton = new System.Windows.Forms.Button();
            this.buttonAddAvailableRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComitee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedChairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedPCMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Possible chairs or PC members";
            // 
            // dataGridViewComitee
            // 
            this.dataGridViewComitee.AllowUserToAddRows = false;
            this.dataGridViewComitee.AllowUserToDeleteRows = false;
            this.dataGridViewComitee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComitee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComitee.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewComitee.Name = "dataGridViewComitee";
            this.dataGridViewComitee.ReadOnly = true;
            this.dataGridViewComitee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewComitee.RowHeadersVisible = false;
            this.dataGridViewComitee.Size = new System.Drawing.Size(280, 363);
            this.dataGridViewComitee.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Added chair(s)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewAddedChairs
            // 
            this.dataGridViewAddedChairs.AllowUserToAddRows = false;
            this.dataGridViewAddedChairs.AllowUserToDeleteRows = false;
            this.dataGridViewAddedChairs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAddedChairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddedChairs.Location = new System.Drawing.Point(317, 27);
            this.dataGridViewAddedChairs.Name = "dataGridViewAddedChairs";
            this.dataGridViewAddedChairs.RowHeadersVisible = false;
            this.dataGridViewAddedChairs.Size = new System.Drawing.Size(280, 78);
            this.dataGridViewAddedChairs.TabIndex = 5;
            // 
            // buttonAddChair
            // 
            this.buttonAddChair.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddChair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddChair.Location = new System.Drawing.Point(317, 111);
            this.buttonAddChair.Name = "buttonAddChair";
            this.buttonAddChair.Size = new System.Drawing.Size(135, 25);
            this.buttonAddChair.TabIndex = 6;
            this.buttonAddChair.Text = "Add chair";
            this.buttonAddChair.UseVisualStyleBackColor = false;
            this.buttonAddChair.Click += new System.EventHandler(this.buttonAddChair_Click);
            // 
            // buttonRemoveChair
            // 
            this.buttonRemoveChair.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveChair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveChair.Location = new System.Drawing.Point(458, 111);
            this.buttonRemoveChair.Name = "buttonRemoveChair";
            this.buttonRemoveChair.Size = new System.Drawing.Size(135, 25);
            this.buttonRemoveChair.TabIndex = 7;
            this.buttonRemoveChair.Text = "Remove chair";
            this.buttonRemoveChair.UseVisualStyleBackColor = false;
            this.buttonRemoveChair.Click += new System.EventHandler(this.buttonRemoveChair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Added PC members";
            // 
            // dataGridViewAddedPCMembers
            // 
            this.dataGridViewAddedPCMembers.AllowUserToAddRows = false;
            this.dataGridViewAddedPCMembers.AllowUserToDeleteRows = false;
            this.dataGridViewAddedPCMembers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAddedPCMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddedPCMembers.Location = new System.Drawing.Point(317, 175);
            this.dataGridViewAddedPCMembers.Name = "dataGridViewAddedPCMembers";
            this.dataGridViewAddedPCMembers.RowHeadersVisible = false;
            this.dataGridViewAddedPCMembers.Size = new System.Drawing.Size(280, 215);
            this.dataGridViewAddedPCMembers.TabIndex = 11;
            // 
            // buttonAddPCMember
            // 
            this.buttonAddPCMember.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddPCMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPCMember.Location = new System.Drawing.Point(317, 396);
            this.buttonAddPCMember.Name = "buttonAddPCMember";
            this.buttonAddPCMember.Size = new System.Drawing.Size(135, 25);
            this.buttonAddPCMember.TabIndex = 12;
            this.buttonAddPCMember.Text = "Add PC member";
            this.buttonAddPCMember.UseVisualStyleBackColor = false;
            this.buttonAddPCMember.Click += new System.EventHandler(this.buttonAddPCMember_Click);
            // 
            // buttonRemovePCMember
            // 
            this.buttonRemovePCMember.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemovePCMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemovePCMember.Location = new System.Drawing.Point(462, 396);
            this.buttonRemovePCMember.Name = "buttonRemovePCMember";
            this.buttonRemovePCMember.Size = new System.Drawing.Size(135, 25);
            this.buttonRemovePCMember.TabIndex = 13;
            this.buttonRemovePCMember.Text = "Remove PC member";
            this.buttonRemovePCMember.UseVisualStyleBackColor = false;
            this.buttonRemovePCMember.Click += new System.EventHandler(this.buttonRemovePCMember_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Conference name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Edition";
            // 
            // textBoxConferenceEdition
            // 
            this.textBoxConferenceEdition.Location = new System.Drawing.Point(703, 53);
            this.textBoxConferenceEdition.Name = "textBoxConferenceEdition";
            this.textBoxConferenceEdition.Size = new System.Drawing.Size(189, 20);
            this.textBoxConferenceEdition.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Website";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxConferenceWebsite
            // 
            this.textBoxConferenceWebsite.Location = new System.Drawing.Point(703, 79);
            this.textBoxConferenceWebsite.Name = "textBoxConferenceWebsite";
            this.textBoxConferenceWebsite.Size = new System.Drawing.Size(189, 20);
            this.textBoxConferenceWebsite.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "City";
            // 
            // textBoxConferenceCity
            // 
            this.textBoxConferenceCity.Location = new System.Drawing.Point(703, 105);
            this.textBoxConferenceCity.Name = "textBoxConferenceCity";
            this.textBoxConferenceCity.Size = new System.Drawing.Size(189, 20);
            this.textBoxConferenceCity.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Country";
            // 
            // textBoxConferenceCountry
            // 
            this.textBoxConferenceCountry.Location = new System.Drawing.Point(703, 135);
            this.textBoxConferenceCountry.Name = "textBoxConferenceCountry";
            this.textBoxConferenceCountry.Size = new System.Drawing.Size(189, 20);
            this.textBoxConferenceCountry.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(769, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Complete paper deadline:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(771, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(615, 274);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker3.TabIndex = 53;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(770, 274);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker4.TabIndex = 54;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(615, 322);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker5.TabIndex = 55;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(770, 322);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker6.TabIndex = 56;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.Location = new System.Drawing.Point(615, 370);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker7.TabIndex = 57;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(770, 370);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownPrice.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(767, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "Participation price($):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Abstract deadline:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(612, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Participation deadline:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(768, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Bidding deadline:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(612, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Evaluation deadline:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(768, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Begin date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "End date:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubmit.Location = new System.Drawing.Point(615, 396);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(280, 25);
            this.buttonSubmit.TabIndex = 80;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxConferenceName
            // 
            this.textBoxConferenceName.Location = new System.Drawing.Point(703, 27);
            this.textBoxConferenceName.Name = "textBoxConferenceName";
            this.textBoxConferenceName.Size = new System.Drawing.Size(189, 20);
            this.textBoxConferenceName.TabIndex = 81;
            // 
            // addTopicsButton
            // 
            this.addTopicsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addTopicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTopicsButton.Location = new System.Drawing.Point(615, 161);
            this.addTopicsButton.Name = "addTopicsButton";
            this.addTopicsButton.Size = new System.Drawing.Size(135, 34);
            this.addTopicsButton.TabIndex = 82;
            this.addTopicsButton.Text = "Add topics";
            this.addTopicsButton.UseVisualStyleBackColor = false;
            this.addTopicsButton.Click += new System.EventHandler(this.addTopicsButton_Click);
            // 
            // buttonAddAvailableRoom
            // 
            this.buttonAddAvailableRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddAvailableRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAvailableRoom.Location = new System.Drawing.Point(772, 161);
            this.buttonAddAvailableRoom.Name = "buttonAddAvailableRoom";
            this.buttonAddAvailableRoom.Size = new System.Drawing.Size(120, 34);
            this.buttonAddAvailableRoom.TabIndex = 83;
            this.buttonAddAvailableRoom.Text = "Available Rooms";
            this.buttonAddAvailableRoom.UseVisualStyleBackColor = false;
            this.buttonAddAvailableRoom.Click += new System.EventHandler(this.buttonAddAvailableRoom_Click);
            // 
            // AdminPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 440);
            this.Controls.Add(this.buttonAddAvailableRoom);
            this.Controls.Add(this.addTopicsButton);
            this.Controls.Add(this.textBoxConferenceName);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.dateTimePicker7);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxConferenceCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxConferenceCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxConferenceWebsite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxConferenceEdition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRemovePCMember);
            this.Controls.Add(this.buttonAddPCMember);
            this.Controls.Add(this.dataGridViewAddedPCMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemoveChair);
            this.Controls.Add(this.buttonAddChair);
            this.Controls.Add(this.dataGridViewAddedChairs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewComitee);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel2";
            this.Text = "AdminPanel2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComitee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedChairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedPCMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewComitee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAddedChairs;
        private System.Windows.Forms.Button buttonAddChair;
        private System.Windows.Forms.Button buttonRemoveChair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAddedPCMembers;
        private System.Windows.Forms.Button buttonAddPCMember;
        private System.Windows.Forms.Button buttonRemovePCMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxConferenceEdition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConferenceWebsite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxConferenceCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxConferenceCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxConferenceName;
        private System.Windows.Forms.Button addTopicsButton;
        private System.Windows.Forms.Button buttonAddAvailableRoom;
    }
}