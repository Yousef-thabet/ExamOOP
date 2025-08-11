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
        public abstract void ShowQuestion(ref double totalMarks);
        public override string ToString()
        {
            string answersString = string.Join("\n", Answers.Select(a => a.ToString()));
            return $"{Header} . {Body}\n (Mark: {Mark})\n{answersString}";

        }

    }
}
