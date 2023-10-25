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
        String[] wrongAnswersArray = new String[3]; 
        private int gameNumber = 0;
        Random random = new Random();

        //add call numbers and their descriptions to the dictionary
        public Identifying_Areas()
        {
            DeweyDecimalsDictionary.Add("000", "General Knowledge");
            DeweyDecimalsDictionary.Add("100", "Philosophy & Psychology");
            DeweyDecimalsDictionary.Add("200", "Religion");
            DeweyDecimalsDictionary.Add("300", "Social Sciences");
            DeweyDecimalsDictionary.Add("400", "Languages");
            DeweyDecimalsDictionary.Add("500", "Science");
            DeweyDecimalsDictionary.Add("600", "Technology");
            DeweyDecimalsDictionary.Add("700", "Arts & Recreation");
            DeweyDecimalsDictionary.Add("800", "Literature");
            DeweyDecimalsDictionary.Add("900", "History & Geography");
        }


        //Ive generated Get and Set methods here
        public Dictionary<string, string> RandomQuestionsDictionary { get => randomQuestionsDictionary; set => randomQuestionsDictionary = value; }
        public int GameNumber { get => gameNumber; set => gameNumber = value; }
        public string[] WrongAnswersArray { get => wrongAnswersArray; set => wrongAnswersArray = value; }
        public Dictionary<string, string> DeweyDecimalsDictionary { get => deweyDecimalsDictionary; set => deweyDecimalsDictionary = value; }




        //Generate Radom Questions linking it to the dictinonary 
        public void RandomQuestion()
        {
            int size = 0;
            int rIndex;
            //clear previous question
            RandomQuestionsDictionary.Clear();
            Dictionary<string, string> wrongAnsDicts = DeweyDecimalsDictionary;

            
            for (int i = 0; i < 4; i++)
            {
                size = wrongAnsDicts.Count;
                rIndex = random.Next(size);
                KeyValuePair<string, string> answerToAdd = wrongAnsDicts.ElementAt(rIndex);
                RandomQuestionsDictionary.Add(answerToAdd.Key, answerToAdd.Value);
                wrongAnsDicts.Remove(answerToAdd.Key);
            }
            
            for (int n = 0; n < 3; n++)
            {
                size = wrongAnsDicts.Count;
                rIndex = random.Next(size);
                KeyValuePair<string, string> wrongAnswerToAdd = wrongAnsDicts.ElementAt(rIndex);

                
                if (gameNumber % 2 == 0)
                {
                    wrongAnswersArray[n] = wrongAnswerToAdd.Value;
                }
                
                else
                {
                    wrongAnswersArray[n] = wrongAnswerToAdd.Key.ToString();
                }
                wrongAnsDicts.Remove(wrongAnswerToAdd.Key);
            }
        }


        // Cross refrences the answers and validates it 
        public bool Validate(String key, String value)
        {
            bool isCorrect = false;
            if (randomQuestionsDictionary.ContainsKey(key))
            {
                string correctValue = randomQuestionsDictionary[key];
                if (value.Equals(correctValue)) isCorrect = true;
            }
            return isCorrect;
        }


        //Ive created a method that the questions gets shuffeled around 
        public List<string> moveAround(List<String> listToShuffle)
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

    }
}

