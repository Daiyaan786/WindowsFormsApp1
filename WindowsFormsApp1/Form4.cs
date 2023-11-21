using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        //******************************************************************************************************************//
        //List of created variables
        //For random number generator
        private static Random rnd = new Random();

        // Counter for elapsed time
        private int elapsedTime = 0; 

        //To validate the answer 
        private string answer;
        private string secondAnswer;
        private string thirdAnswer;

        //For choosing the game, and score
       
        private int currentQuestion = 1;
        private int currentScore = 0;

        //To check the answer
        private bool endGame = false;

        //Lists for the input, processing and the output, as well as a list of buttons
        BookTreeModel randomRecord = new BookTreeModel();
        List<string> input = System.IO.File.ReadAllLines("DeweyData.txt").ToList();
        List<BookTreeModel> processing = new List<BookTreeModel>();
        List<BookTreeModel> output = new List<BookTreeModel>();
        List<Button> answerButtons = new List<Button>();

        //******************************************************************************************************************//
        /// <summary>
        /// Main Class
        /// </summary>
        public Form4()
        {
            InitializeComponent();
        }

        //******************************************************************************************************************//
        //adding all of the buttons togeather 
        public void addingAnswerButtons()
        {
            answerButtons.Add(answer1Btn);
            answerButtons.Add(answer2Btn);
            answerButtons.Add(answer3Btn);
            answerButtons.Add(answer4Btn);
        }


        


        //******************************************************************************************************************//
       //Start Game button
      
        private void GenerateNumbersBtn_Click(object sender, EventArgs e)
        {
            GenerateNumbersBtn.Enabled = false;
            currentQuestion = 1;
            questionCounterLbl.Text = $"Question: {currentQuestion}" +
                                      $"\n Score: {currentScore}";

            foreach (var button in answerButtons)
            {
                button.Enabled = true;
            }
            //Check if the data has been processed already
            if (processing.Count == 0)
            {
                ProcessData();
            }

            FirstQuestionGen();
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to process the data from the text file into the tree
        /// </summary>
        private void ProcessData()
        {
            //Prepare the processing object to be processed
            processing = input.Select(s =>
            {
                var record = s.Split('_');

                var index = Int32.Parse(record[0]);
                var name = record[1].Replace("&", "&&");

                return new BookTreeModel()
                {
                    Index = index,
                    Category = name.Trim(),
                    Children = new List<BookTreeModel>()
                };
            }).ToList();

            //First processing to get the first level of books from the data
            var initialBooks = processing.Where(b => b.Index % 100 == 0).ToList();
            output.AddRange(initialBooks);

            foreach (var book in output)
            {
                var startIndex = book.Index;
                var breakPoint = startIndex + 100;

                //Assigning the second level books to the first level
                var secondLevelBooksToProcess = processing.Where(b => b.Index > startIndex && b.Index < breakPoint);
                var secondLevelBooks = secondLevelBooksToProcess.Where(b => b.Index % 10 == 0).ToList();

                //Assigning the third level books to the second level
                foreach (var child in secondLevelBooks)
                {
                    var c_startIndex = child.Index;
                    var c_breakPoint = c_startIndex + 10;

                    var thirdLevelbooksToProcess =
                        processing.Where(b => b.Index > c_startIndex && b.Index < c_breakPoint);
                    var thirdLevelbooks = thirdLevelbooksToProcess.Where(b => b.Index % 1 == 0).ToList();

                    child.Children.AddRange(thirdLevelbooks);
                }

                book.Children.AddRange(secondLevelBooks);
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to generate the first set of answers from the data set and populate the buttons with them.
        /// This is creating the tree structure as well as sorting the specific data and populating the buttons with them in order.
        /// </summary>
        private void FirstQuestionGen()
        {
            endGame = false;

            List<string> answerList = new List<string>();

            var firstRndNum = rnd.Next(0, output.Count);

            var firstPart = output.ToArray()[firstRndNum];

            var secondRndNum = rnd.Next(0, firstPart.Children.Count);

            var secondPart = firstPart.Children.ToArray()[secondRndNum];

            var thirdRndNum = rnd.Next(0, secondPart.Children.Count);

            var thirdPart = secondPart.Children.ToArray()[thirdRndNum];

            randomRecord = new BookTreeModel()
            {
                Index = firstPart.Index,
                Category = firstPart.Category,
                Children = new List<BookTreeModel>()
                {
                    new BookTreeModel()
                    {
                        Index = secondPart.Index,
                        Category = secondPart.Category,
                        Children = new List<BookTreeModel>()
                        {
                            new BookTreeModel()
                            {
                                Index = thirdPart.Index,
                                Category = thirdPart.Category,
                            }
                        }
                    }
                }
            };

            answer = $"{randomRecord.Index.ToString("D3")} {randomRecord.Category}";
            secondAnswer = $"{randomRecord.Children[0].Index.ToString("D3")} {randomRecord.Children[0].Category}";
            thirdAnswer = randomRecord.Children[0].Children[0].Category;

            questionLbl.Text = thirdPart.Category;

            answerList.Add($"{firstPart.Index.ToString("D3")} {firstPart.Category}");

            while (answerList.Count < 4)
            {
                var randomNumber = rnd.Next(0, output.Count);
                var randomBook = output.ToArray()[randomNumber];

                if (!answerList.Contains($"{randomBook.Index.ToString("D3")} {randomBook.Category}"))
                {
                    answerList.Add($"{randomBook.Index.ToString("D3")} {randomBook.Category}");
                }
            }

            answerList.Sort();

            for (int i = 0; i < answerButtons.Count; i++)
            {
                answerButtons[i].Text = answerList[i];
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to populate the buttons with the second level data
        /// after the first answer has been chosen as is correct then the answers will be populated with a deeper more specific level
        /// </summary>
        private void SecondQuestionGen()
        {
            List<string> answerList = new List<string>();

            var correctAnswer = randomRecord.Children[0];

            answerList.Add($"{correctAnswer.Index.ToString("D3")} {correctAnswer.Category}");

            var secondLevelAnswers = output.FirstOrDefault(b => b.Index == randomRecord.Index).Children;

            while (answerList.Count < 4)
            {
                var randomNumber = rnd.Next(0, secondLevelAnswers.Count);
                var randomBook = secondLevelAnswers.ToArray()[randomNumber];

                if (!answerList.Contains($"{randomBook.Index.ToString("D3")} {randomBook.Category}"))
                {
                    answerList.Add($"{randomBook.Index.ToString("D3")} {randomBook.Category}");
                }
            }

            answerList.Sort();

            for (int i = 0; i < answerButtons.Count; i++)
            {
                answerButtons[i].Text = answerList[i];
            }

            answer = $"{correctAnswer.Index.ToString("D3")} {correctAnswer.Category}";

            endGame = true;
        }

        //******************************************************************************************************************//
        /// <summary>
        /// On page load event which populates the buttons into the list as well as clears all text fields and gets the page ready to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
        {
            addingAnswerButtons();
            clearMethod();
        }
        private void UpdateProgressBar()
        {
            // Calculate the percentage of progress based on the currentScore
            float progressPercentage = (float)currentScore / progressBar1.Maximum;

            // Calculate the value to set for the ProgressBar (25% of the total width for each 500 points)
            int progressBarValue = (int)(progressPercentage * progressBar1.Maximum * 0.25);

            // Ensure that the progressBarValue is within the valid range
            progressBarValue = Math.Max(progressBar1.Minimum, Math.Min(progressBar1.Maximum, progressBarValue));

            // Set the ProgressBar value
            progressBar1.Value = progressBarValue;
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Button to validate that the correct answer has been chosen and add the score and question according to what the user has done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answer1Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var text = button.Text;
            var answer = this.answer;

            if (text.Equals(answer, StringComparison.CurrentCulture))
            {
                MessageBox.Show("Correct!");
                if (!endGame)
                {
                    SecondQuestionGen();
                }
                else
                {
                    FirstQuestionGen();
                    currentScore += 500;
                    currentQuestion += 1;
                    questionCounterLbl.Text = $"Question: {currentQuestion}" +
                                              $"\nScore: {currentScore}";
                    UpdateProgressBar();

                }

            }
            else
            {
                MessageBox.Show("Incorrect! Try Again!");
                clearMethod();
                MessageBox.Show($"Game Over! " +
                                $"\nYou made it to question: {currentQuestion}." +
                                $"\nYour final score is: {currentScore}.");
                currentScore = 0;
                currentQuestion = 0;
                questionCounterLbl.Text = $"Question: {currentQuestion}" +
                                          $"\nScore: {currentScore}";
                UpdateProgressBar();
            }
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Method to clear all the buttons and text fields for when the game is over and when the page loads
        /// </summary>
        private void clearMethod()
        {
            GenerateNumbersBtn.Enabled = true;

            //Clear the answer buttons
            foreach (var button in answerButtons)
            {
                //Disable buttons and clear text
                button.Enabled = false;
                button.Text = "-Answers-";
            }

            //Clear the question label
            questionLbl.Text = "-Question-";
        }

        //******************************************************************************************************************//
        /// <summary>
        /// Button event for when the user wants to end the game
        /// Their score and final question will be displayed to them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endGameBtn_Click(object sender, EventArgs e)
        {
            if (questionLbl.Text == "-Question-")
            {
                MessageBox.Show("PLEASE START THE GAME WITH THE START GAME BUTTON!");
            }
            else
            {
                clearMethod();
                MessageBox.Show($"Game Over! " +
                                $"\nWelldone you made it to Question : {currentQuestion}." +
                                $"\nThe score you got is: {currentScore}.");
            }
        }

        private void questionLbl_Click(object sender, EventArgs e)
        {

        }


        private void questionCounterLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/daiyaan135i/");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/daiyaan.marais");
        }

        private void viewRulesBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();       
           


            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            elapsedTime++;
            label9.Text = $"Total Time: {elapsedTime} seconds";
        }

        private void help1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Choose the correct answer remember the game will become for difficult ");
        }

        private void endGameBtn_Click_1(object sender, EventArgs e)
        {
            clearMethod();
            MessageBox.Show($"Game Ended! " +
                            $"\nYou made it to question: {currentQuestion}." +
                            $"\nYour final score is: {currentScore}.");
            currentScore = 0;
            currentQuestion = 0;
            questionCounterLbl.Text = $"Question: {currentQuestion}" +
                                      $"\nScore: {currentScore}";
        }

     

        private void progressBar1_Click(object sender, EventArgs e)
        {

            

        }
    }
    //*********************************************************ooo CLASS END ooo*********************************************************//
}
