using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Replacing_Books
    {
        private List<Dewey_Decimal> deweyList = new List<Dewey_Decimal>();
        private List<Dewey_Decimal> sortedList = new List<Dewey_Decimal>();
        private int score;
        private Random random = new Random();
        //ToCharArray 
        private Char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


        public Replacing_Books()
        {
            this.GenerateList();
        }

        //dewey list 
        public List<Dewey_Decimal> DeweyList { get => deweyList; set => deweyList = value; }
      

        //Generate a list 
        public void GenerateList()
        {

            for (int i = 0; i < 10; i++)
            {
                String AuthorName = "";
                double TopicWholeNum = random.Next(0, 888);
                double TopicDecimalNum = random.NextDouble();
                double TopicNum = Math.Round(TopicWholeNum + TopicDecimalNum, 2);
                Dewey_Decimal CallingNumber = new Dewey_Decimal();


                for (int n = 0; n < 3; n++)
                {
                    int character = random.Next(1, 26);
                    AuthorName += alphabet[character];
                }


                CallingNumber.DescriptionPart = AuthorName;
                CallingNumber.CallNumberPart = TopicNum;
                DeweyList.Add(CallingNumber);
            }
        }

        //SortList for the list
        public List<Dewey_Decimal> SortList()
        {
            sortedList = DeweyList;

            //This is the sorting method
            sortedList.Sort(delegate (Dewey_Decimal p1, Dewey_Decimal p2)
            {
                var topicNum = p1.CallNumberPart.CompareTo(p2.CallNumberPart);
                return topicNum == 0 ? p1.DescriptionPart.CompareTo(p2.DescriptionPart) : topicNum;
            });

            return sortedList;
        }




    }
}