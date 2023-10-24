using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Identifying_Areas
    {
        //dictionary to store the callnumbers and their description
        private Dictionary<string, string> deweyDecimalsDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> randomQuestionsDictionary = new Dictionary<string, string>();
        String[] wrongAnswersArray = new String[3]; //list for wrong answers
        //used to alternate between call numbers, and description questions
        private int gameNumber = 0;
        Random random = new Random();

        //add call numbers and their descriptions to the dictionary
        public Identifying_Areas()
        {
            DeweyDecimalsDictionary.Add("000-099", "General Works");
            DeweyDecimalsDictionary.Add("100-199", "Philosophy and Psychology");
            DeweyDecimalsDictionary.Add("200-299", "Religion");
            DeweyDecimalsDictionary.Add("300-399", "Social Sciences");
            DeweyDecimalsDictionary.Add("400-499", "Language");
            DeweyDecimalsDictionary.Add("500-599", "Natural Sciences and Mathematics");
            DeweyDecimalsDictionary.Add("600-699", "Technology");
            DeweyDecimalsDictionary.Add("700-799", "The Arts");
            DeweyDecimalsDictionary.Add("800-899", "Literature and Rhetoric");
            DeweyDecimalsDictionary.Add("900-999", "History, Biography, and Geography");
        }


        //gets and sets
        public Dictionary<string, string> RandomQuestionsDictionary { get => randomQuestionsDictionary; set => randomQuestionsDictionary = value; }
        public int GameNumber { get => gameNumber; set => gameNumber = value; }
        public string[] WrongAnswersArray { get => wrongAnswersArray; set => wrongAnswersArray = value; }
        public Dictionary<string, string> DeweyDecimalsDictionary { get => deweyDecimalsDictionary; set => deweyDecimalsDictionary = value; }




        //generate a random question using the Dewey Decimal Dictionary
        public void GenerateRandomQuestion()
        {
            int size = 0;
            int rIndex;
            //clear previous question
            RandomQuestionsDictionary.Clear();
            Dictionary<string, string> wrongAnsDicts = DeweyDecimalsDictionary;

            //correct answe
            for (int i = 0; i < 4; i++)
            {
                size = wrongAnsDicts.Count;
                rIndex = random.Next(size);
                KeyValuePair<string, string> answerToAdd = wrongAnsDicts.ElementAt(rIndex);
                RandomQuestionsDictionary.Add(answerToAdd.Key, answerToAdd.Value);
                wrongAnsDicts.Remove(answerToAdd.Key);
            }
            //wrong answers
            for (int n = 0; n < 3; n++)
            {
                size = wrongAnsDicts.Count;
                rIndex = random.Next(size);
                KeyValuePair<string, string> wrongAnswerToAdd = wrongAnsDicts.ElementAt(rIndex);

                //even call numbers
                if (gameNumber % 2 == 0)
                {
                    wrongAnswersArray[n] = wrongAnswerToAdd.Value;
                }
                //odd descriptions
                else
                {
                    wrongAnswersArray[n] = wrongAnswerToAdd.Key.ToString();
                }
                wrongAnsDicts.Remove(wrongAnswerToAdd.Key);
            }
        }



        //randomly shuffle the answers of the question
        public List<string> ShuffleAnswers(List<String> listToShuffle)
        {
            List<string> shuffledList = listToShuffle;
            int i = shuffledList.Count;
            while (i > 1)
            {
                i--;
                int index = random.Next(i + 1);
                //random value swap
                String value = shuffledList[index];
                shuffledList[index] = shuffledList[i];
                shuffledList[i] = value;
            }
            return shuffledList;
        }


        // Checks the answer dictionary
        public bool ValidateAnswer(String key, String value)
        {
            bool isCorrect = false;
            if (randomQuestionsDictionary.ContainsKey(key))
            {
                string correctValue = randomQuestionsDictionary[key];
                if (value.Equals(correctValue)) isCorrect = true;
            }
            return isCorrect;
        }

    }
}

