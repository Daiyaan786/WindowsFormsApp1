using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Replacing_Books_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME TO THE END !", "HOPE YOU DONT FAIL 100 TIMES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }
        //As form One laods 
        private void Form1_Load(object sender, EventArgs e)
        {
            
                try
            { 
                    // Create a SoundPlayer instance and specify the path to your audio file.
                    SoundPlayer player = new SoundPlayer(@"C:\Users\daiya\Downloads\Slow Smooth Soothing Instrumental Music for relaxing, studying, work relaxdaily N°063.wav");

                    // Play the audio file.
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred Dr Rudolf please check is the .wav is installed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        //Close application 
        private void QuitBtn1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Identifying_Areas_Click(object sender, EventArgs e)
        {

            MessageBox.Show("So The game is a drage and drop from Box B to Box A and when pressed next question itll calculate ypur score /nr" +
                "Here are the Game Answeres to refresh your memory " +
                "000 -General Knowledge" +
                "100 - Philosophy & Psychology" +
                "200 - Religion" +
                "300 - Social Sciences" +
                "400 - Languages" +
                "500 - Science" +
                "600 - Technology" +
                "700 - Arts & Recreation" +
                "800 - Literature" +
                "900 - History & Geography", "How to play ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 f8= new Form3();
            f8.Show();

        }

        private void Find_Call_Numbers_Click(object sender, EventArgs e)
        {
            //Message box Coming soon
            MessageBox.Show("404!", "COMING SOON", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }
    }
}
