using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Net
{
     [Serializable()]
    public class question
    {
        private int mQuestionID;
        private string mQuestion;
        private string mQuestionType;
        private string[] mPossibleAnswers;
        private string mAnswer;

        public int QuestionID
        {
            get { return mQuestionID; }
            set { mQuestionID = value; }
        }
        public string Question
        {
            get { return mQuestion; }
            set { mQuestion = value; }
        }
        public string QuestionType
        {
            get { return mQuestionType; }
            set { mQuestionType = value; }
        }
        public string[] PossibleAnswers
        {
            get { return mPossibleAnswers; }
            set { mPossibleAnswers = value; }
        }
        public string Answer
        {
            get { return mAnswer; }
            set { mAnswer = value; }
        }

        // Remove X chars from the start of the string
        public string RemoveFrontCharacters(string prString, int prNumToRemove)
        {
            int iCount = 0;
            int iStringLength = prString.Length;
            char[] iStringArray = new char[100];// prString.ToCharArray();

            for (int i = 0; i < iStringLength; i++)
            {
                if (i >= prNumToRemove)
                {
                    if (prString[i] != ';')
                    {
                        iStringArray[iCount] = prString[i];
                        iCount++;
                    }
                    else
                    {
                        iStringArray[iCount] = prString[i];
                        return new string(iStringArray);
                    }
                }
            }
            return new string(iStringArray);
        }

        public void ProcessQuestion(string prQuestion)
        {
            DictionarySerialiserMethods iSerialiserMethods = new DictionarySerialiserMethods();
            question iNewQuestion = iSerialiserMethods.ConvertStringToQuestion(prQuestion);

            mQuestion = iNewQuestion.Question;
            mQuestionID = iNewQuestion.QuestionID;
            mQuestionType = iNewQuestion.QuestionType;
            mPossibleAnswers = iNewQuestion.PossibleAnswers;
            mAnswer = iNewQuestion.Answer;
        }
    }
}

