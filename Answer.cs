using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Net
{
    class Answer
    {
        private string mAnswerToSubmit = "";

        public string AnswerToSubmit
        {
            get { return mAnswerToSubmit; }
            set { mAnswerToSubmit = value; }
        }

        // Turn the provided answer into a answer string
        // E.g. A;1|Answer;
        public void ProcessAnswer(int prQuestionID, string prAnswer)
        {
            mAnswerToSubmit = "A;" + prQuestionID.ToString() + "|" + prAnswer + ";";
        }
    }
}
