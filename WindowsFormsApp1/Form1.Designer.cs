﻿namespace WindowsFormsApp1
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
            this.QuitBtn1 = new System.Windows.Forms.Button();
            this.Find_Call_Numbers = new System.Windows.Forms.Button();
            this.Identifying_Areas = new System.Windows.Forms.Button();
            this.Replacing_Books = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuitBtn1
            // 
            this.QuitBtn1.Location = new System.Drawing.Point(353, 369);
            this.QuitBtn1.Name = "QuitBtn1";
            this.QuitBtn1.Size = new System.Drawing.Size(102, 37);
            this.QuitBtn1.TabIndex = 10;
            this.QuitBtn1.Text = "Quit";
            this.QuitBtn1.UseVisualStyleBackColor = true;
            this.QuitBtn1.Click += new System.EventHandler(this.QuitBtn1_Click);
            // 
            // Find_Call_Numbers
            // 
            this.Find_Call_Numbers.Location = new System.Drawing.Point(527, 264);
            this.Find_Call_Numbers.Name = "Find_Call_Numbers";
            this.Find_Call_Numbers.Size = new System.Drawing.Size(102, 37);
            this.Find_Call_Numbers.TabIndex = 9;
            this.Find_Call_Numbers.Text = "Finding Call Numbers";
            this.Find_Call_Numbers.UseVisualStyleBackColor = true;
            this.Find_Call_Numbers.Click += new System.EventHandler(this.Find_Call_Numbers_Click);
            // 
            // Identifying_Areas
            // 
            this.Identifying_Areas.Location = new System.Drawing.Point(353, 264);
            this.Identifying_Areas.Name = "Identifying_Areas";
            this.Identifying_Areas.Size = new System.Drawing.Size(102, 37);
            this.Identifying_Areas.TabIndex = 8;
            this.Identifying_Areas.Text = "Identifying Areas";
            this.Identifying_Areas.UseVisualStyleBackColor = true;
            this.Identifying_Areas.Click += new System.EventHandler(this.Identifying_Areas_Click);
            // 
            // Replacing_Books
            // 
            this.Replacing_Books.BackColor = System.Drawing.Color.Transparent;
            this.Replacing_Books.Location = new System.Drawing.Point(167, 264);
            this.Replacing_Books.Name = "Replacing_Books";
            this.Replacing_Books.Size = new System.Drawing.Size(102, 37);
            this.Replacing_Books.TabIndex = 7;
            this.Replacing_Books.Text = "Replacing Books";
            this.Replacing_Books.UseVisualStyleBackColor = true;
            this.Replacing_Books.Click += new System.EventHandler(this.Replacing_Books_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(156, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dewey Decimal Games";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitBtn1);
            this.Controls.Add(this.Find_Call_Numbers);
            this.Controls.Add(this.Identifying_Areas);
            this.Controls.Add(this.Replacing_Books);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitBtn1;
        private System.Windows.Forms.Button Find_Call_Numbers;
        private System.Windows.Forms.Button Identifying_Areas;
        private System.Windows.Forms.Button Replacing_Books;
        private System.Windows.Forms.Label label1;
    }
}
