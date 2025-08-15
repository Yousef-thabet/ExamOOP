using System;

namespace Exam_OOP.Question
{
    /// <summary>
    /// Represents an answer with associated text and a unique identifier.
    /// </summary>
    /// <remarks>This class provides a way to encapsulate an answer's text and its unique identifier.
    /// Instances of this class are immutable after creation.</remarks>
    public class Answer
    {
        public string AnswerText { get; }
        public int AnswerId { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Answer"/> class with the specified text and identifier.
        /// </summary>
        /// <param name="answerText">The text of the answer. Cannot be null or empty.</param>
        /// <param name="answerId">The unique identifier for the answer.</param>
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
