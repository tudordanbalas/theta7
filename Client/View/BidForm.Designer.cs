﻿namespace Client.View
{
    partial class BidForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPlaceBid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Neutral",
            "Want to evaluate",
            "Don\'t want to evaluate"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonPlaceBid
            // 
            this.buttonPlaceBid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceBid.Location = new System.Drawing.Point(95, 93);
            this.buttonPlaceBid.Name = "buttonPlaceBid";
            this.buttonPlaceBid.Size = new System.Drawing.Size(75, 25);
            this.buttonPlaceBid.TabIndex = 1;
            this.buttonPlaceBid.Text = "Submit";
            this.buttonPlaceBid.UseVisualStyleBackColor = true;
            this.buttonPlaceBid.Click += new System.EventHandler(this.buttonPlaceBid_Click);
            // 
            // BidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 128);
            this.Controls.Add(this.buttonPlaceBid);
            this.Controls.Add(this.comboBox1);
            this.Name = "BidForm";
            this.Text = "BidForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPlaceBid;
    }
}