using Exam_OOP.Question;
using System;

using H = Exam_OOP.Helper;
using Q = Exam_OOP.Question;
namespace Exam_OOP.Exam
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int numOfQusetion, int time, Q.Question[] Questions) : base(numOfQusetion, time, Questions)
        {
           
        }

        public override void ShowExam()
        {
            double totalMarks = 0;
            Console.WriteLine("Practical Exam");
            foreach (var q in Questions)
            {
                q.ShowQuestion(ref totalMarks);
            }
            Console.Clear();
            foreach (var q in Questions)
            {
                Console.WriteLine($"Correct Answer: {q.RightAnswer.AnswerText}\n");
            }
            Console.WriteLine("Your grade is: {0}", totalMarks);
        }
        public override string ToString()
        {
            return $"Practical Exam:\n{base.ToString()}";
        }
    }
}
