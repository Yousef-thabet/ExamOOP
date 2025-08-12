using System.Diagnostics;

using E = Exam_OOP.Exam;
using H = Exam_OOP.Helper;
using Q = Exam_OOP.Question;
namespace Exam_OOP.Subject;

public class Subject
{

    /// <summary>
    /// class subject 
    /// </summary>
    public int Id { get; set; }
    public string Name { get; set; }
    public List<E.Exam> Exams { get; set; } = new List<E.Exam>();

    /// <summary>
    /// constractor for subject class
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    public Subject(int id, string name )
    {
        Id = id;
        Name = name;
        
    }
    /// <summary>
    /// Creates a new exam for the current subject based on user input.
    /// </summary>
    /// <remarks>This method prompts the user to specify the type of exam, the number of questions, and the
    /// duration of the exam. Depending on the selected exam type, it creates either a final exam or a practical exam
    /// and adds it to the list of exams. The user is also prompted to define the type and content of each
    /// question.</remarks>
    public void CreateExam()
    {
        Console.WriteLine("Creating Exam for Subject: " + Name);
        int _examType= H.Helper.GetNumber("Choose Exam Type:\n1. Final Exam\n2. Practical Exam\n:",1, 2);
        int _numOfQuestions = H.Helper.GetNumber("Enter Number of Questions: ", 1, 100);
        int _time = H.Helper.GetNumber("Enter Exam Time (in minutes): ", 1, 120);
        Q.Question[] _questions = new Q.Question[_numOfQuestions];
        
        
        if (_examType == 1)
        {
            for (int i = 0; i < _numOfQuestions; i++)
            {
                int qType = H.Helper.GetNumber("Enter Question Type (1: MCQ, 2: True/False): ", 1, 2);
                if (qType == 1)
                {
                    _questions[i] = Q.MCQQuestion.CreateMCQQuestion($"Q{++i}");
                }else if(qType == 2)
                {
                    _questions[i] = Q.TrueFalseQuestion.CreateTrueFalseQuestion($"Q{++i}");
                }

            }

            Exams.Add(new E.FinalExam(_numOfQuestions, _time, _questions));
        }
        else if (_examType == 2)
        {
            for (int i = 0; i < _numOfQuestions; i++)
            {  
             _questions[i] = Q.MCQQuestion.CreateMCQQuestion($"Q{++i}");
            }

            
            Exams.Add(new E.PracticalExam(_numOfQuestions, _time, _questions));
        }
        else
        {
            Console.WriteLine("Invalid Exam Type");
            return;
        }
        Console.Clear();
        Console.WriteLine("Exam Created Successfully for Subject: " + Name);
        Console.ReadKey();
    }
    /// <summary>
    /// Starts the selected exam for the current subject and tracks the elapsed time.
    /// </summary>
    /// <remarks>This method prompts the user to select an exam by its ID and starts the corresponding exam if
    /// it exists.  The elapsed time for the exam is measured and displayed upon completion. If the selected exam ID is
    /// invalid  or no exams are available, an appropriate message is displayed to the user.</remarks>
    public void StartExams()
    {
        int numOfExams = H.Helper.GetNumber("Enter Exam ID to start: \n![0]for first exam\n ", 0, Exams.Count);
        Console.Clear();
        if(Exams is not null && numOfExams >= 0 && numOfExams < Exams.Count)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep((Exams[numOfExams].Time) * 60);

            Exams[numOfExams].ShowExam();
            
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

           
            
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
               ts.Hours, ts.Minutes, ts.Seconds,
               ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
        else if (numOfExams < Exams?.Count)
        {
            Console.WriteLine("No Exams by this id Available for Subject: {0}" , Name); Console.ReadKey();
        }
        else { Console.WriteLine("No Exams Avilaple for Subject {0}",Name);Console.ReadKey(); }

        Console.ReadKey();
    }
   /// <summary>
   /// Displays the details of a specific exam for the current subject.
   /// </summary>
   /// <remarks>Prompts the user to enter an exam ID and displays the details of the corresponding exam if it
   /// exists. If the entered ID is invalid or no exams are available, an appropriate message is displayed.</remarks>
    public void PrintExams()
        {
        
        int numOfExams = H.Helper.GetNumber("Enter Exam ID to view details:\n![0]for first exam\n ", 0, Exams.Count);
        if (Exams is not null && numOfExams >= 0 && numOfExams < Exams.Count)
        {
            Console.WriteLine("Exams for Subject: {0}" , Name);
            Console.WriteLine(Exams[numOfExams].ToString());
            Console.ReadKey();
        }else if(numOfExams < Exams?.Count)
        {
            Console.WriteLine("No Exams by this id Available for Subject: {0}" , Name); Console.ReadKey();
        }
        else
        {
            Console.WriteLine("No Exams Available for Subject: {0}" , Name); Console.ReadKey();
        }
    }
}
