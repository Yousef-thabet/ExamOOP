using System;

using H = Exam_OOP.Helper;

namespace Exam_OOP.Question
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, double mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {
        }

        public override void ShowQuestion(ref double totalMarks)
        {
            Console.WriteLine($"{Header} . {Body}\n (Mark: {Mark})");
            foreach (var ans in Answers) { Console.WriteLine(ans); }

            int ansId = H.Helper.GetNumber("Your Answer ID: ", 1,2);
            if (ansId == RightAnswer.AnswerId)
                totalMarks += Mark;

        }
        public static TrueFalseQuestion CreateTrueFalseQuestion()
        {
            string header = H.Helper.GetString("Question head: ");
            string body = H.Helper.GetString("Question body: ");
            double mark = H.Helper.GetNumber("Enter Question Mark: ");

            Answer[] answers = new Answer[]
            {
                new Answer("true",1),
                new Answer("false",2)
            };

       
            int correctId = H.Helper.GetNumber("Enter Correct Answer ID: ", 1, 2);

            return new TrueFalseQuestion(header, body, mark, answers, answers[correctId - 1]);
        }
    }
}
