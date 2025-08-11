using System;

namespace Exam_OOP.Question
{
    public class Answer
    {
        public string AnswerText { get; }
        public int AnswerId { get; }

        public Answer(string answerText, int answerId)
        {
            AnswerText = answerText;
            AnswerId = answerId;
        }
        public override string ToString()
        {
            return $"{AnswerId}.{AnswerText}" ;
        }
    }
}
