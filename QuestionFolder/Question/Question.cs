using System;


namespace Exam_OOP.Question
{
    public abstract class Question
    {
       
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark {  get; set; }

        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, double mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }
        /// <summary>
        /// Displays a question to the user and updates the total marks based on the user's response.
        /// </summary>
        /// <remarks>The method is abstract and must be implemented by a derived class. The implementation
        /// should define how the question is presented and how the user's response affects the <paramref
        /// name="totalMarks"/> value.</remarks>
        /// <param name="totalMarks">A reference to the total marks accumulated so far. This value will be updated based on the user's response
        /// to the question.</param>
        public abstract void ShowQuestion(ref double totalMarks);
        public override string ToString()
        {
            string answersString = string.Join("\n", Answers.Select(a => a.ToString()));
            return $"{Header} . {Body}\n (Mark: {Mark})\n{answersString}";

        }

    }
}
