using WindowsFormsApp1;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        private void ResultListView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string selectedItem = (string)e.Data.GetData(typeof(string));

                // Add the dropped item to the ResultListView
              

                // Remove the item from the RandomBookList
                RandomBookList.Items.Remove(selectedItem);
            }
        }
        private void ResultListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void RandomBookList_MouseDown(object sender, MouseEventArgs e)
        {
            if (RandomBookList.SelectedItem != null)
            {
                RandomBookList.DoDragDrop(RandomBookList.SelectedItem, DragDropEffects.Move);
            }
        }
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BackBtn1 = new System.Windows.Forms.Button();
            this.GameProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentScoreLbl = new System.Windows.Forms.Label();
            this.TotalScoreLbl = new System.Windows.Forms.Label();
            this.TotalScoreTxtLbl = new System.Windows.Forms.Label();
            this.CurrentScoreTxtLbl = new System.Windows.Forms.Label();
            this.RandomBookList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NextListBtn = new System.Windows.Forms.Button();
            this.VerifyListBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DownListBtn = new System.Windows.Forms.Button();
            this.UpListBtn = new System.Windows.Forms.Button();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn1
            // 
            this.BackBtn1.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.R;
            this.BackBtn1.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.BackBtn1.ForeColor = System.Drawing.Color.Yellow;
            this.BackBtn1.Location = new System.Drawing.Point(0, 1);
            this.BackBtn1.Name = "BackBtn1";
            this.BackBtn1.Size = new System.Drawing.Size(123, 43);
            this.BackBtn1.TabIndex = 52;
            this.BackBtn1.Text = "Return";
            this.BackBtn1.UseVisualStyleBackColor = false;
            this.BackBtn1.Click += new System.EventHandler(this.BackBtn1_Click);
            // 
            // GameProgressBar
            // 
            this.GameProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GameProgressBar.BackColor = System.Drawing.Color.Yellow;
            this.GameProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.GameProgressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GameProgressBar.Location = new System.Drawing.Point(159, 284);
            this.GameProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.GameProgressBar.Name = "GameProgressBar";
            this.GameProgressBar.Size = new System.Drawing.Size(511, 31);
            this.GameProgressBar.TabIndex = 51;
            this.GameProgressBar.Click += new System.EventHandler(this.GameProgressBar_Click);
            // 
            // CurrentScoreLbl
            // 
            this.CurrentScoreLbl.Location = new System.Drawing.Point(0, 0);
            this.CurrentScoreLbl.Name = "CurrentScoreLbl";
            this.CurrentScoreLbl.Size = new System.Drawing.Size(100, 23);
            this.CurrentScoreLbl.TabIndex = 0;
            // 
            // TotalScoreLbl
            // 
            this.TotalScoreLbl.Location = new System.Drawing.Point(0, 0);
            this.TotalScoreLbl.Name = "TotalScoreLbl";
            this.TotalScoreLbl.Size = new System.Drawing.Size(100, 23);
            this.TotalScoreLbl.TabIndex = 0;
            // 
            // TotalScoreTxtLbl
            // 
            this.TotalScoreTxtLbl.AutoSize = true;
            this.TotalScoreTxtLbl.Location = new System.Drawing.Point(10, 7);
            this.TotalScoreTxtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalScoreTxtLbl.Name = "TotalScoreTxtLbl";
            this.TotalScoreTxtLbl.Size = new System.Drawing.Size(65, 13);
            this.TotalScoreTxtLbl.TabIndex = 16;
            this.TotalScoreTxtLbl.Text = "Total Score:";
            // 
            // CurrentScoreTxtLbl
            // 
            this.CurrentScoreTxtLbl.AutoSize = true;
            this.CurrentScoreTxtLbl.Location = new System.Drawing.Point(10, 28);
            this.CurrentScoreTxtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentScoreTxtLbl.Name = "CurrentScoreTxtLbl";
            this.CurrentScoreTxtLbl.Size = new System.Drawing.Size(75, 13);
            this.CurrentScoreTxtLbl.TabIndex = 15;
            this.CurrentScoreTxtLbl.Text = "Current Score:";
            // 
            // RandomBookList
            // 
            this.RandomBookList.AllowDrop = true;
            this.RandomBookList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RandomBookList.BackColor = System.Drawing.Color.LightBlue;
            this.RandomBookList.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomBookList.FormattingEnabled = true;
            this.RandomBookList.ItemHeight = 15;
            this.RandomBookList.Location = new System.Drawing.Point(159, 65);
            this.RandomBookList.Margin = new System.Windows.Forms.Padding(2);
            this.RandomBookList.MinimumSize = new System.Drawing.Size(91, 197);
            this.RandomBookList.MultiColumn = true;
            this.RandomBookList.Name = "RandomBookList";
            this.RandomBookList.Size = new System.Drawing.Size(511, 199);
            this.RandomBookList.TabIndex = 46;
            this.RandomBookList.SelectedIndexChanged += new System.EventHandler(this.RandomBookList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(357, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Final Results";
            // 
            // NextListBtn
            // 
            this.NextListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextListBtn.BackColor = System.Drawing.Color.Cyan;
            this.NextListBtn.Enabled = false;
            this.NextListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextListBtn.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.NextListBtn.Location = new System.Drawing.Point(159, 323);
            this.NextListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NextListBtn.Name = "NextListBtn";
            this.NextListBtn.Size = new System.Drawing.Size(177, 70);
            this.NextListBtn.TabIndex = 40;
            this.NextListBtn.Text = "TEST ME AGAIN";
            this.NextListBtn.UseVisualStyleBackColor = false;
            this.NextListBtn.Click += new System.EventHandler(this.NextListBtn_Click);
            // 
            // VerifyListBtn
            // 
            this.VerifyListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VerifyListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VerifyListBtn.Enabled = false;
            this.VerifyListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyListBtn.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.VerifyListBtn.ForeColor = System.Drawing.Color.Black;
            this.VerifyListBtn.Location = new System.Drawing.Point(491, 323);
            this.VerifyListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VerifyListBtn.Name = "VerifyListBtn";
            this.VerifyListBtn.Size = new System.Drawing.Size(179, 70);
            this.VerifyListBtn.TabIndex = 43;
            this.VerifyListBtn.Text = "MARK ME ";
            this.VerifyListBtn.UseVisualStyleBackColor = false;
            this.VerifyListBtn.Click += new System.EventHandler(this.VerifyListBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(155, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Called numbers ";
            // 
            // DownListBtn
            // 
            this.DownListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DownListBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.DownListBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.arrowdownred;
            this.DownListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownListBtn.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.DownListBtn.Location = new System.Drawing.Point(75, 198);
            this.DownListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DownListBtn.Name = "DownListBtn";
            this.DownListBtn.Size = new System.Drawing.Size(70, 66);
            this.DownListBtn.TabIndex = 45;
            this.DownListBtn.UseVisualStyleBackColor = false;
            this.DownListBtn.Click += new System.EventHandler(this.DownListBtn_Click_1);
            // 
            // UpListBtn
            // 
            this.UpListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpListBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpListBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.R44;
            this.UpListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpListBtn.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.UpListBtn.Location = new System.Drawing.Point(75, 65);
            this.UpListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpListBtn.Name = "UpListBtn";
            this.UpListBtn.Size = new System.Drawing.Size(71, 59);
            this.UpListBtn.TabIndex = 44;
            this.UpListBtn.UseVisualStyleBackColor = false;
            this.UpListBtn.Click += new System.EventHandler(this.UpListBtn_Click_1);
            // 
            // ResultListView
            // 
            this.ResultListView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResultListView.BackColor = System.Drawing.Color.LightBlue;
            this.ResultListView.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultListView.HideSelection = false;
            this.ResultListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ResultListView.Location = new System.Drawing.Point(559, 65);
            this.ResultListView.Margin = new System.Windows.Forms.Padding(2);
            this.ResultListView.MinimumSize = new System.Drawing.Size(91, 192);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(91, 192);
            this.ResultListView.TabIndex = 54;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            this.ResultListView.SelectedIndexChanged += new System.EventHandler(this.ResultListView_SelectedIndexChanged_1);
            // 
            // ScorePanel
            // 
            this.ScorePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScorePanel.BackColor = System.Drawing.Color.Peru;
            this.ScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScorePanel.Controls.Add(this.label1);
            this.ScorePanel.Controls.Add(this.label4);
            this.ScorePanel.Controls.Add(this.label5);
            this.ScorePanel.Controls.Add(this.label6);
            this.ScorePanel.Controls.Add(this.label7);
            this.ScorePanel.Location = new System.Drawing.Point(351, 339);
            this.ScorePanel.Margin = new System.Windows.Forms.Padding(2);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(122, 54);
            this.ScorePanel.TabIndex = 55;
            this.ScorePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ScorePanel_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Current Score:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Form2_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackBtn1);
            this.Controls.Add(this.GameProgressBar);
            this.Controls.Add(this.RandomBookList);
            this.Controls.Add(this.DownListBtn);
            this.Controls.Add(this.UpListBtn);
            this.Controls.Add(this.VerifyListBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextListBtn);
            this.Controls.Add(this.ResultListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn1;
        private System.Windows.Forms.ProgressBar GameProgressBar;
        private System.Windows.Forms.Label CurrentScoreLbl;
        private System.Windows.Forms.Label TotalScoreLbl;
        private System.Windows.Forms.Label TotalScoreTxtLbl;
        private System.Windows.Forms.Label CurrentScoreTxtLbl;
        private System.Windows.Forms.ListBox RandomBookList;
        private System.Windows.Forms.Button DownListBtn;
        private System.Windows.Forms.Button UpListBtn;
        private System.Windows.Forms.Button VerifyListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextListBtn;
        private Label label3;
        private ListView ResultListView;
        private Panel ScorePanel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Timer timer1;
        private Label label1;

        public PaintEventHandler ScorePanel_Paint { get; private set; }
    }
}