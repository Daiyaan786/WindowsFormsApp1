using WindowsFormsApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Replacing_Books replacingBooks;
        private List<Dewey_Decimal> displayedBooks; //call numbers in dewey decimal
        private int currentScore; //Current score
        private int totalScore; //Total score
        private Replacing_Books thebooks; // Random call numbers in list
        private List<Dewey_Decimal> sortedList; // Sorted call numbers list
       


        public Form2()
        {
            InitializeComponent();

           // Create an instance of Replacing_Books and initialize variables
            replacingBooks = new Replacing_Books();
            displayedBooks = new List<Dewey_Decimal>();
            currentScore = 0;
            totalScore = 0;
            thebooks = new Replacing_Books(); // Initialize thebooks
           


            // Generate and display the initial set of random books
            GenerateAndDisplayBooks();


        }
        
        //Generate and Displaying the books 
        private void GenerateAndDisplayBooks()
        {
            // Generate and display 10 random books
            replacingBooks.GenerateList();
            displayedBooks = replacingBooks.DeweyList.GetRange(0, 10);

            // Clear the ListBox and add the books to it
            RandomBookList.Items.Clear();
            foreach (var book in displayedBooks)
            {
                RandomBookList.Items.Add(book.ToString());
            }

            // Reset the score and progress bar
            currentScore = 0;
            totalScore = 0;
            CurrentScoreLbl.Text = currentScore.ToString();
            TotalScoreLbl.Text = totalScore.ToString();
            GameProgressBar.Value = 0;

            // Enable/disable buttons as needed
            NextListBtn.Enabled = true;
            VerifyListBtn.Enabled = true;

            // Initialize and sort the sortedList
            sortedList = new List<Dewey_Decimal>(displayedBooks); // Create a copy of displayedBooks
           
        }

        
        private void NextListBtn_Click(object sender, EventArgs e)
        {
            // Regenerate and display the next set of random books
            GenerateAndDisplayBooks();
            this.PrintRandomBooks();
        }


        

        private void VerifyListBtn_Click(object sender, EventArgs e)
        {



            // Get the displayed items as a list of Dewey_Decimal objects
            List<Dewey_Decimal> displayedItems = new List<Dewey_Decimal>();
            foreach (var item in RandomBookList.Items)
            {
                displayedItems.Add(new Dewey_Decimal(item.ToString()));
            }

            // Calculate the score and mark each item correctly
            int score = CalculateScore(displayedItems);

            // Update the score labels
            currentScore = score;
            label4.Text = currentScore.ToString();

            // Update the progress bar
            totalScore += score;
            label5.Text = totalScore.ToString();
            
            // Check if the progress bar is full
            if (totalScore >= GameProgressBar.Maximum)
            {
                // Display a game over message
                MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                // You can choose to restart the game or take any other action here

                // Reset the progress bar and score
                totalScore = 0;
                GameProgressBar.Value = 0;
            }
            GameProgressBar.Value = totalScore;
            this.PrintRandomBooks();

            // Disable the Verify button and enable the Next button
            VerifyListBtn.Enabled = true;
            NextListBtn.Enabled = true;
          //  VerifyUserList();
            
           
        }


        //calculate the score and add it to a label 
        private int CalculateScore(List<Dewey_Decimal> displayed)
        {
            int score = 0;
            int correctCount = 0; // Count of correct items

            for (int i = 0; i < displayed.Count; i++)
            {
                if (i == 0 || string.Compare(displayed[i].ToString(), displayed[i - 1].ToString()) > 0)
                {
                    // Check if the current item is greater than the previous one (in ascending order)
                    correctCount++; // Increment the count of correct items
                }

                score = correctCount; // Mark each item with its correct position
            }

            return score;
        }

        private void RandomBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the Verify button when an item is selected
            VerifyListBtn.Enabled = true;

        }


        private void UpListBtn_Click_1(object sender, EventArgs e)
        {
            MoveListItem(true);
        }
        
        private int secondsElapsed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            label1.Text = $"Time Elapsed: {secondsElapsed} seconds";
        }
        //move the list up
        private void MoveListItem(bool up)
        {
            try
            {
                // Item must be selected
                if (RandomBookList.SelectedIndex == -1) return;

                int newIndex;
                if (up)
                {
                    // Move up
                    newIndex = RandomBookList.SelectedIndex - 1;
                }
                else
                {
                    // Move down
                    newIndex = RandomBookList.SelectedIndex + 1;
                }
                if (newIndex < 0 || newIndex >= 10) return;

                object selectedItem = RandomBookList.SelectedItem;
                RandomBookList.Items.Remove(selectedItem);
                RandomBookList.Items.Insert(newIndex, selectedItem);
                RandomBookList.SetSelected(newIndex, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }

        }

        //set it false so that itll do the opposite 
        private void DownListBtn_Click_1(object sender, EventArgs e)
        {
            MoveListItem(false);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            timer1.Start();
        }
         
        
        private void SortRandomBooks()
        {
            sortedList = new List<Dewey_Decimal>();
            sortedList = thebooks.SortList();
        }
        //Print random books 
        private void PrintRandomBooks()
        {
            thebooks = new Replacing_Books();
            RandomBookList.Items.Clear();
            //printing to textbox
            foreach (var book in thebooks.DeweyList)
            {
                RandomBookList.Items.Add(book);
            }
            SortRandomBooks();
        }

        private void BackBtn1_Click(object sender, EventArgs e)
        {
            this.Close();

            
            
            Form1 previousForm = new Form1();
            previousForm.Show();
        }

       

        private void ResultListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       

        private void ScorePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void GameProgressBar_Click(object sender, EventArgs e)
        {
            
        }
    }
}