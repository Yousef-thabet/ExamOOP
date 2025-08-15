using System;
using System.Collections.Generic;
using System.Linq;

using H = Exam_OOP.Helper;
namespace Exam_OOP.Question
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, double mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {
        }
       
        public override void ShowQuestion(ref double totalMarks)
        {
            Console.WriteLine($"{Header} . {Body}\n (Mark: {Mark})");
            foreach (var ans in Answers) { Console.WriteLine(ans); }

            int ansId = H.Helper.GetNumber("Your Answer ID: ",1,4);
            if (ansId  == RightAnswer.AnswerId)
                totalMarks += Mark;

        }

        public static MCQQuestion CreateMCQQuestion(string header)
        {
            #region variable

            string body = H.Helper.GetString("Question body: ");
            double mark = H.Helper.GetNumber("Enter Question Mark: ", .5, 10);
            int numChoices = H.Helper.GetNumber("Enter Number of Choices (3-6): ", 3, 6); 
            #endregion
            Answer[] answers = new Answer[numChoices];

            for (int i = 0; i < numChoices; i++)
            {
               
                answers[i] = new Answer(H.Helper.GetString($"choice : {i+1}: "), i + 1);
            }
            int correctId = H.Helper.GetNumber("Enter Correct Answer ID: ", 1, numChoices);

            return new MCQQuestion(header, body, mark, answers, answers[correctId - 1]);
        }
    }
}
