using Exam_OOP.Question;
using System;

using H = Exam_OOP.Helper;
using Q = Exam_OOP.Question;

namespace Exam_OOP.Exam
{
    public class FinalExam : Exam
    {
        public FinalExam(int numOfQusetion, int time, Q.Question[] Questions) : base(numOfQusetion, time, Questions)
        {
        }


        public override void ShowExam()
        {
            double totalMarks = 0;
            Console.WriteLine("Final Exam");
            Console.WriteLine("Time : {0}",Time.ToString());
            foreach(var q in Questions)
            {
                q.ShowQuestion(ref totalMarks);
            }
            Console.Clear();
            Console.WriteLine($"Your Grade: {totalMarks}");
        }
        public override string ToString()
        {
            return $"Final Exam:\n{base.ToString()}";
        }
    }
}
