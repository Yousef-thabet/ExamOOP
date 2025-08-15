using System;

using Q = Exam_OOP.Question;

namespace Exam_OOP.Exam
{
    public abstract class Exam
    {
        public int NumOfQusetion {  get; set; }
        public int Time {  get; set; }
        public Q.Question[] Questions { get; set; }
        public double FullMarks { get; set; }

        public Exam(int __numOfQusetion, int __time, Q.Question[] __questions)
        {
            NumOfQusetion = __numOfQusetion;
            Time = __time;
            this.Questions = __questions;
            
        }
        public abstract void ShowExam();
        public override string ToString()
        {
           return $"Number of Questions: {NumOfQusetion}\nTime: {Time} minutes\nQuestions:\n{string.Join("\n", Questions.Select(q => q.ToString()))}\nRight Questions:\n{string.Join("\n", Questions.Select(q => q.RightAnswer.ToString()))}";
        }
    }
}
