﻿using System;

namespace WindowsFormsApp1
{
    partial class Form3
    {
        private const string V = "Form3";

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
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.currentScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreTxtLbl = new System.Windows.Forms.Label();
            this.currentScoreTxtLbl = new System.Windows.Forms.Label();
            this.QuestionNumLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.questionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.answer4ListBox = new System.Windows.Forms.ListBox();
            this.answer3ListBox = new System.Windows.Forms.ListBox();
            this.answer2ListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.question4Lbl = new System.Windows.Forms.Label();
            this.question3Lbl = new System.Windows.Forms.Label();
            this.question2Lbl = new System.Windows.Forms.Label();
            this.question1Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answer1ListBox = new System.Windows.Forms.ListBox();
            this.answerListBox = new System.Windows.Forms.ListBox();
            this.scorePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.questionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold);
            this.NextQuestionButton.Location = new System.Drawing.Point(646, 339);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(109, 40);
            this.NextQuestionButton.TabIndex = 39;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.Return.Location = new System.Drawing.Point(32, 72);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(109, 40);
            this.Return.TabIndex = 38;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Score:";
            // 
            // scorePanel
            // 
            this.scorePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scorePanel.BackColor = System.Drawing.Color.Peru;
            this.scorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorePanel.Controls.Add(this.currentScoreLbl);
            this.scorePanel.Controls.Add(this.totalScoreLbl);
            this.scorePanel.Controls.Add(this.totalScoreTxtLbl);
            this.scorePanel.Controls.Add(this.currentScoreTxtLbl);
            this.scorePanel.Location = new System.Drawing.Point(646, 167);
            this.scorePanel.Margin = new System.Windows.Forms.Padding(2);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(122, 54);
            this.scorePanel.TabIndex = 36;
            // 
            // currentScoreLbl
            // 
            this.currentScoreLbl.AutoSize = true;
            this.currentScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreLbl.Location = new System.Drawing.Point(79, 28);
            this.currentScoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentScoreLbl.Name = "currentScoreLbl";
            this.currentScoreLbl.Size = new System.Drawing.Size(14, 13);
            this.currentScoreLbl.TabIndex = 18;
            this.currentScoreLbl.Text = "0";
            // 
            // totalScoreLbl
            // 
            this.totalScoreLbl.AutoSize = true;
            this.totalScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLbl.Location = new System.Drawing.Point(85, 7);
            this.totalScoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalScoreLbl.Name = "totalScoreLbl";
            this.totalScoreLbl.Size = new System.Drawing.Size(14, 13);
            this.totalScoreLbl.TabIndex = 17;
            this.totalScoreLbl.Text = "0";
            // 
            // totalScoreTxtLbl
            // 
            this.totalScoreTxtLbl.AutoSize = true;
            this.totalScoreTxtLbl.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreTxtLbl.Location = new System.Drawing.Point(16, 7);
            this.totalScoreTxtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalScoreTxtLbl.Name = "totalScoreTxtLbl";
            this.totalScoreTxtLbl.Size = new System.Drawing.Size(65, 15);
            this.totalScoreTxtLbl.TabIndex = 16;
            this.totalScoreTxtLbl.Text = "Total Score:";
            // 
            // currentScoreTxtLbl
            // 
            this.currentScoreTxtLbl.AutoSize = true;
            this.currentScoreTxtLbl.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreTxtLbl.Location = new System.Drawing.Point(6, 28);
            this.currentScoreTxtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentScoreTxtLbl.Name = "currentScoreTxtLbl";
            this.currentScoreTxtLbl.Size = new System.Drawing.Size(77, 15);
            this.currentScoreTxtLbl.TabIndex = 15;
            this.currentScoreTxtLbl.Text = "Current Score:";
            // 
            // QuestionNumLbl
            // 
            this.QuestionNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuestionNumLbl.AutoSize = true;
            this.QuestionNumLbl.BackColor = System.Drawing.Color.White;
            this.QuestionNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionNumLbl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.QuestionNumLbl.Location = new System.Drawing.Point(324, 142);
            this.QuestionNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionNumLbl.Name = "QuestionNumLbl";
            this.QuestionNumLbl.Size = new System.Drawing.Size(95, 23);
            this.QuestionNumLbl.TabIndex = 35;
            this.QuestionNumLbl.Text = "Question 1:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.questionsPanel);
            this.panel1.Controls.Add(this.answerListBox);
            this.panel1.Location = new System.Drawing.Point(127, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 205);
            this.panel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Answers";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Questions";
            // 
            // questionsPanel
            // 
            this.questionsPanel.AllowDrop = true;
            this.questionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.questionsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.questionsPanel.ColumnCount = 3;
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.questionsPanel.Controls.Add(this.answer4ListBox, 2, 3);
            this.questionsPanel.Controls.Add(this.answer3ListBox, 2, 2);
            this.questionsPanel.Controls.Add(this.answer2ListBox, 2, 1);
            this.questionsPanel.Controls.Add(this.label4, 0, 3);
            this.questionsPanel.Controls.Add(this.label3, 0, 2);
            this.questionsPanel.Controls.Add(this.question4Lbl, 1, 3);
            this.questionsPanel.Controls.Add(this.question3Lbl, 1, 2);
            this.questionsPanel.Controls.Add(this.question2Lbl, 1, 1);
            this.questionsPanel.Controls.Add(this.question1Lbl, 1, 0);
            this.questionsPanel.Controls.Add(this.label2, 0, 1);
            this.questionsPanel.Controls.Add(this.label1, 0, 0);
            this.questionsPanel.Controls.Add(this.answer1ListBox, 2, 0);
            this.questionsPanel.Location = new System.Drawing.Point(2, 43);
            this.questionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.RowCount = 4;
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.Size = new System.Drawing.Size(269, 145);
            this.questionsPanel.TabIndex = 7;
            // 
            // answer4ListBox
            // 
            this.answer4ListBox.AllowDrop = true;
            this.answer4ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer4ListBox.BackColor = System.Drawing.Color.LightBlue;
            this.answer4ListBox.Font = new System.Drawing.Font("Constantia", 9F);
            this.answer4ListBox.FormattingEnabled = true;
            this.answer4ListBox.ItemHeight = 14;
            this.answer4ListBox.Location = new System.Drawing.Point(123, 117);
            this.answer4ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.answer4ListBox.Name = "answer4ListBox";
            this.answer4ListBox.Size = new System.Drawing.Size(139, 18);
            this.answer4ListBox.TabIndex = 9;
            // 
            // answer3ListBox
            // 
            this.answer3ListBox.AllowDrop = true;
            this.answer3ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer3ListBox.BackColor = System.Drawing.Color.LightBlue;
            this.answer3ListBox.Font = new System.Drawing.Font("Constantia", 9F);
            this.answer3ListBox.FormattingEnabled = true;
            this.answer3ListBox.ItemHeight = 14;
            this.answer3ListBox.Location = new System.Drawing.Point(124, 81);
            this.answer3ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.answer3ListBox.Name = "answer3ListBox";
            this.answer3ListBox.Size = new System.Drawing.Size(138, 18);
            this.answer3ListBox.TabIndex = 8;
            // 
            // answer2ListBox
            // 
            this.answer2ListBox.AllowDrop = true;
            this.answer2ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer2ListBox.BackColor = System.Drawing.Color.LightBlue;
            this.answer2ListBox.Font = new System.Drawing.Font("Constantia", 9F);
            this.answer2ListBox.FormattingEnabled = true;
            this.answer2ListBox.ItemHeight = 14;
            this.answer2ListBox.Location = new System.Drawing.Point(124, 45);
            this.answer2ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.answer2ListBox.Name = "answer2ListBox";
            this.answer2ListBox.Size = new System.Drawing.Size(138, 18);
            this.answer2ListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // question4Lbl
            // 
            this.question4Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question4Lbl.AutoSize = true;
            this.question4Lbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.question4Lbl.Location = new System.Drawing.Point(23, 118);
            this.question4Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question4Lbl.Name = "question4Lbl";
            this.question4Lbl.Size = new System.Drawing.Size(67, 17);
            this.question4Lbl.TabIndex = 5;
            this.question4Lbl.Text = "Question 4";
            // 
            // question3Lbl
            // 
            this.question3Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question3Lbl.AutoSize = true;
            this.question3Lbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.question3Lbl.Location = new System.Drawing.Point(23, 82);
            this.question3Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question3Lbl.Name = "question3Lbl";
            this.question3Lbl.Size = new System.Drawing.Size(67, 17);
            this.question3Lbl.TabIndex = 4;
            this.question3Lbl.Text = "Question 3";
            // 
            // question2Lbl
            // 
            this.question2Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question2Lbl.AutoSize = true;
            this.question2Lbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.question2Lbl.Location = new System.Drawing.Point(23, 46);
            this.question2Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question2Lbl.Name = "question2Lbl";
            this.question2Lbl.Size = new System.Drawing.Size(67, 17);
            this.question2Lbl.TabIndex = 3;
            this.question2Lbl.Text = "Question 2";
            // 
            // question1Lbl
            // 
            this.question1Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question1Lbl.AutoSize = true;
            this.question1Lbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Lbl.Location = new System.Drawing.Point(23, 10);
            this.question1Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question1Lbl.Name = "question1Lbl";
            this.question1Lbl.Size = new System.Drawing.Size(67, 17);
            this.question1Lbl.TabIndex = 2;
            this.question1Lbl.Text = "Question 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // answer1ListBox
            // 
            this.answer1ListBox.AllowDrop = true;
            this.answer1ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer1ListBox.BackColor = System.Drawing.Color.LightBlue;
            this.answer1ListBox.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1ListBox.FormattingEnabled = true;
            this.answer1ListBox.ItemHeight = 14;
            this.answer1ListBox.Location = new System.Drawing.Point(124, 9);
            this.answer1ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.answer1ListBox.Name = "answer1ListBox";
            this.answer1ListBox.Size = new System.Drawing.Size(138, 18);
            this.answer1ListBox.TabIndex = 6;
            // 
            // answerListBox
            // 
            this.answerListBox.AllowDrop = true;
            this.answerListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerListBox.BackColor = System.Drawing.Color.LightBlue;
            this.answerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerListBox.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerListBox.FormattingEnabled = true;
            this.answerListBox.ItemHeight = 16;
            this.answerListBox.Location = new System.Drawing.Point(276, 43);
            this.answerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.answerListBox.Name = "answerListBox";
            this.answerListBox.Size = new System.Drawing.Size(224, 146);
            this.answerListBox.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.QuestionNumLbl);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
           this.Load += new System.EventHandler(this.Form3_Load);
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.questionsPanel.ResumeLayout(false);
            this.questionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label currentScoreLbl;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.Label totalScoreTxtLbl;
        private System.Windows.Forms.Label currentScoreTxtLbl;
        private System.Windows.Forms.Label QuestionNumLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel questionsPanel;
        private System.Windows.Forms.ListBox answer4ListBox;
        private System.Windows.Forms.ListBox answer3ListBox;
        private System.Windows.Forms.ListBox answer2ListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label question4Lbl;
        private System.Windows.Forms.Label question3Lbl;
        private System.Windows.Forms.Label question2Lbl;
        private System.Windows.Forms.Label question1Lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox answer1ListBox;
        private System.Windows.Forms.ListBox answerListBox;

        public EventHandler Form3_Load { get; private set; }
    }
}