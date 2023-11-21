namespace WindowsFormsApp1
{
    partial class Form4
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
            this.questionCounterLbl = new System.Windows.Forms.Label();
            this.endGameBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.answer4Btn = new System.Windows.Forms.Button();
            this.answer3Btn = new System.Windows.Forms.Button();
            this.answer2Btn = new System.Windows.Forms.Button();
            this.answer1Btn = new System.Windows.Forms.Button();
            this.viewRulesBtn = new System.Windows.Forms.Button();
            this.GenerateNumbersBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // questionCounterLbl
            // 
            this.questionCounterLbl.BackColor = System.Drawing.Color.Yellow;
            this.questionCounterLbl.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCounterLbl.Location = new System.Drawing.Point(372, 514);
            this.questionCounterLbl.Name = "questionCounterLbl";
            this.questionCounterLbl.Size = new System.Drawing.Size(283, 54);
            this.questionCounterLbl.TabIndex = 27;
            this.questionCounterLbl.Text = "Question:\r\nScore:";
            this.questionCounterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionCounterLbl.Click += new System.EventHandler(this.questionCounterLbl_Click_1);
            // 
            // endGameBtn
            // 
            this.endGameBtn.BackColor = System.Drawing.Color.Black;
            this.endGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGameBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.endGameBtn.Location = new System.Drawing.Point(575, 425);
            this.endGameBtn.Name = "endGameBtn";
            this.endGameBtn.Size = new System.Drawing.Size(121, 45);
            this.endGameBtn.TabIndex = 26;
            this.endGameBtn.Text = "End Game";
            this.endGameBtn.UseVisualStyleBackColor = false;
            this.endGameBtn.Click += new System.EventHandler(this.endGameBtn_Click_1);
            // 
            // questionLbl
            // 
            this.questionLbl.BackColor = System.Drawing.Color.Yellow;
            this.questionLbl.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(202, 108);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(663, 23);
            this.questionLbl.TabIndex = 25;
            this.questionLbl.Text = "-Question-";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLbl.Click += new System.EventHandler(this.questionLbl_Click);
            // 
            // answer4Btn
            // 
            this.answer4Btn.BackColor = System.Drawing.Color.Yellow;
            this.answer4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer4Btn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4Btn.ForeColor = System.Drawing.Color.Black;
            this.answer4Btn.Location = new System.Drawing.Point(582, 330);
            this.answer4Btn.Name = "answer4Btn";
            this.answer4Btn.Size = new System.Drawing.Size(283, 34);
            this.answer4Btn.TabIndex = 24;
            this.answer4Btn.Text = "-Answers-";
            this.answer4Btn.UseVisualStyleBackColor = false;
            this.answer4Btn.Click += new System.EventHandler(this.answer1Btn_Click);
            // 
            // answer3Btn
            // 
            this.answer3Btn.BackColor = System.Drawing.Color.Yellow;
            this.answer3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer3Btn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3Btn.ForeColor = System.Drawing.Color.Black;
            this.answer3Btn.Location = new System.Drawing.Point(206, 330);
            this.answer3Btn.Name = "answer3Btn";
            this.answer3Btn.Size = new System.Drawing.Size(283, 34);
            this.answer3Btn.TabIndex = 23;
            this.answer3Btn.Text = "-Answers-";
            this.answer3Btn.UseVisualStyleBackColor = false;
            this.answer3Btn.Click += new System.EventHandler(this.answer1Btn_Click);
            // 
            // answer2Btn
            // 
            this.answer2Btn.BackColor = System.Drawing.Color.Yellow;
            this.answer2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer2Btn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2Btn.ForeColor = System.Drawing.Color.Black;
            this.answer2Btn.Location = new System.Drawing.Point(582, 205);
            this.answer2Btn.Name = "answer2Btn";
            this.answer2Btn.Size = new System.Drawing.Size(283, 34);
            this.answer2Btn.TabIndex = 22;
            this.answer2Btn.Text = "-Answers-";
            this.answer2Btn.UseVisualStyleBackColor = false;
            this.answer2Btn.Click += new System.EventHandler(this.answer1Btn_Click);
            // 
            // answer1Btn
            // 
            this.answer1Btn.BackColor = System.Drawing.Color.Yellow;
            this.answer1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer1Btn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1Btn.ForeColor = System.Drawing.Color.Black;
            this.answer1Btn.Location = new System.Drawing.Point(206, 205);
            this.answer1Btn.Name = "answer1Btn";
            this.answer1Btn.Size = new System.Drawing.Size(283, 34);
            this.answer1Btn.TabIndex = 21;
            this.answer1Btn.Text = "-Answers-";
            this.answer1Btn.UseVisualStyleBackColor = false;
            this.answer1Btn.Click += new System.EventHandler(this.answer1Btn_Click);
            // 
            // viewRulesBtn
            // 
            this.viewRulesBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewRulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRulesBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRulesBtn.ForeColor = System.Drawing.Color.Yellow;
            this.viewRulesBtn.Location = new System.Drawing.Point(25, 12);
            this.viewRulesBtn.Name = "viewRulesBtn";
            this.viewRulesBtn.Size = new System.Drawing.Size(115, 46);
            this.viewRulesBtn.TabIndex = 20;
            this.viewRulesBtn.Text = "RETURN";
            this.viewRulesBtn.UseVisualStyleBackColor = false;
            this.viewRulesBtn.Click += new System.EventHandler(this.viewRulesBtn_Click_1);
            // 
            // GenerateNumbersBtn
            // 
            this.GenerateNumbersBtn.BackColor = System.Drawing.Color.Black;
            this.GenerateNumbersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateNumbersBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateNumbersBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.GenerateNumbersBtn.Location = new System.Drawing.Point(314, 425);
            this.GenerateNumbersBtn.Name = "GenerateNumbersBtn";
            this.GenerateNumbersBtn.Size = new System.Drawing.Size(129, 45);
            this.GenerateNumbersBtn.TabIndex = 19;
            this.GenerateNumbersBtn.Text = "Start Game";
            this.GenerateNumbersBtn.UseVisualStyleBackColor = false;
            this.GenerateNumbersBtn.Click += new System.EventHandler(this.GenerateNumbersBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.backBtn.Location = new System.Drawing.Point(104, 634);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 34);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.ForeColor = System.Drawing.Color.Yellow;
            this.exitAppBtn.Location = new System.Drawing.Point(915, 12);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(66, 34);
            this.exitAppBtn.TabIndex = 17;
            this.exitAppBtn.Text = "HELP";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.Click += new System.EventHandler(this.help1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Follow me on Social Media ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.instagram;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(858, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 46);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.facebook1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.facebook;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(933, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 46);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(243, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Timer : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(63, 522);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 45);
            this.progressBar1.TabIndex = 40;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(1003, 579);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionCounterLbl);
            this.Controls.Add(this.endGameBtn);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.answer4Btn);
            this.Controls.Add(this.answer3Btn);
            this.Controls.Add(this.answer2Btn);
            this.Controls.Add(this.answer1Btn);
            this.Controls.Add(this.viewRulesBtn);
            this.Controls.Add(this.GenerateNumbersBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.exitAppBtn);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionCounterLbl;
        private System.Windows.Forms.Button endGameBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button answer4Btn;
        private System.Windows.Forms.Button answer3Btn;
        private System.Windows.Forms.Button answer2Btn;
        private System.Windows.Forms.Button answer1Btn;
        private System.Windows.Forms.Button viewRulesBtn;
        private System.Windows.Forms.Button GenerateNumbersBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}