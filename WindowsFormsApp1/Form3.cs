﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private Identifying_Areas identfiyingAreas;
        private int gameNumber = 0;
        private object listItem;
        private ListBox fromBox;
        private int currentScore = 0;
        private int totalScore = 0;
        public Form3()
        {
            InitializeComponent();
            ResetGame();
        }

        // next question button to calculate score
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            totalScore += currentScore; // udpating score
            totalScoreLbl.Text = String.Format("{0}/{1}", totalScore, (gameNumber * 4));
            currentScoreLbl.Text = "0/4";
            CreateQuestion();

        }
        // match the columns question
        public void CreateQuestion()
        {
            this.gameNumber++; // increasing game number
            QuestionNumLbl.Text = String.Format("Question {0}:", gameNumber);
            this.identfiyingAreas = new Identifying_Areas();
            this.identfiyingAreas.GameNumber = gameNumber;
            this.identfiyingAreas.GenerateRandomQuestion(); // generating question
            ClearAnswerBox();
            SetupQuestion();
        }


        // match the columns question that was generated
        public void SetupQuestion()
        {
            currentScore = 0; //reset current score for next question
            if (gameNumber % 2 == 0)
            {
                // even numbers
                String[] questionArray = identfiyingAreas.RandomQuestionsDictionary.Keys.ToArray();
                SetupLeftQuestions(questionArray);
                List<String> answerList = identfiyingAreas.RandomQuestionsDictionary.Values.ToList();
                answerList.AddRange(identfiyingAreas.WrongAnswersArray);
                answerList = identfiyingAreas.ShuffleAnswers(answerList); // shuffle
                SetupRightAnswers(answerList);
            }
            //odd descriptions
            else
            {
                // questions
                String[] questionArray = identfiyingAreas.RandomQuestionsDictionary.Values.ToArray();
                SetupLeftQuestions(questionArray);
                // answers combining the dictionary with wrong answers list
                List<String> answerList = identfiyingAreas.RandomQuestionsDictionary.Keys.ToList();
                answerList.AddRange(identfiyingAreas.WrongAnswersArray);
                answerList = identfiyingAreas.ShuffleAnswers(answerList); // shuffle
                SetupRightAnswers(answerList);
            }
        }


        // left side of the questions set up
        public void SetupLeftQuestions(String[] questions)
        {
            int count = 0;
            var labels = questionsPanel.Controls.OfType<Label>().Where(c => c.Name.StartsWith("question")).ToList();
            labels.Reverse();
            foreach (Label lbl in labels)
            {
                lbl.Text = questions[count];
                count++;
            }
        }

        // setup the right side (answers)
        public void SetupRightAnswers(List<String> answers)
        {
            answerListBox.Items.Clear();
            foreach (var item in answers)
            {
                answerListBox.Items.Add(item);
            }
        }

        /// Drag and drop list boxxes 
        private void Answer_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ListBox box = (ListBox)sender;
                fromBox = box;
                if (box.SelectedItem != null)
                {
                    String text = box.SelectedItem.ToString();
                    listItem = box.SelectedItem;
                    DoDragDrop(text, DragDropEffects.Copy);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Drag Error Occured");
            }
        }

        ///  Allowing list box dragging
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            // data is text format
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // answer is dropped into a listbox
        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                String text = e.Data.GetData("Text", true) as String;


                ListBox answerBox = (ListBox)sender;
                if (answerBox != fromBox)
                {

                    if ((answerBox != answerListBox) && (answerBox.Items.Count < 1))
                    {
                        fromBox.Items.Remove(listItem);
                        answerBox.Items.Add(text);
                        CheckAnswer();
                    }
                    if (answerBox == answerListBox)
                    {
                        fromBox.Items.Remove(listItem);
                        answerBox.Items.Add(text);
                        CheckAnswer();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Drag Error Occured");
            }
        }

        // check if the answer was correct
        public void CheckAnswer()
        {
            int score = 0;
            var boxes = questionsPanel.Controls.OfType<ListBox>().ToList();
            foreach (var item in boxes)
            {
                if (item.Items.Count != 0)
                {

                    String listBoxName = item.Name;
                    String answer = item.Items[0].ToString();
                    int index = Convert.ToInt32(listBoxName[6].ToString()) - 1;
                    string question;
                    bool isCorrect;
                    // even will call number
                    if (gameNumber % 2 == 0)
                    {
                        question = this.identfiyingAreas.RandomQuestionsDictionary.ElementAt(index).Key; //call num
                        isCorrect = this.identfiyingAreas.ValidateAnswer(question, answer);
                    }
                    // odd will call descriptions
                    else
                    {
                        question = this.identfiyingAreas.RandomQuestionsDictionary.ElementAt(index).Value; //descr
                        isCorrect = this.identfiyingAreas.ValidateAnswer(answer, question);
                    }

                    if (isCorrect == true)
                    {
                        // right
                        item.ForeColor = Color.Green;
                        score++;

                    }
                    else
                    {
                        // wrong
                        item.ForeColor = Color.Red;
                    }
                }
            }
            UpdateScore(score);
        }


        // clear the answer boxes when a new question is generated
        private void ClearAnswerBox()
        {
            var boxes = questionsPanel.Controls.OfType<ListBox>().ToList();
            foreach (var item in boxes)
            {
                item.Items.Clear();
            }
        }


        // update the score of the game
        private void UpdateScore(int scoreChange)
        {
            currentScore = scoreChange;
            currentScoreLbl.Text = String.Format("{0}/4", currentScore);
        }


        // button click to reset game
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        // reset game
        private void ResetGame()
        {
            gameNumber = 0;
            totalScore = 0;
            currentScore = 0;
            totalScoreLbl.Text = "0";
            currentScoreLbl.Text = "0";
            CreateQuestion();
        }

        // send user back to main page
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mp1 = new Form1();
            mp1.Show();
        }


    }
}