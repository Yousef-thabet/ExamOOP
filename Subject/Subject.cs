using System.Diagnostics;using E = Exam_OOP.Exam;using H = Exam_OOP.Helper;using Q = Exam_OOP.Question;namespace Exam_OOP.Subject;public class Subject{    public int Id { get; set; }    public string Name { get; set; }    public List<E.Exam> Exams { get; set; } = new List<E.Exam>();    public Subject(int id, string name )    {        Id = id;        Name = name;            }    public void CreateExam()    {        Console.WriteLine("Creating Exam for Subject: " + Name);        int _examType= H.Helper.GetNumber("Choose Exam Type:\n1. Final Exam\n2. Practical Exam\n:",1, 2);        int _numOfQuestions = H.Helper.GetNumber("Enter Number of Questions: ", 1, 100);        int _time = H.Helper.GetNumber("Enter Exam Time (in minutes): ", 1, 120);        Q.Question[] _questions = new Q.Question[_numOfQuestions];                        if (_examType == 1)        {            for (int i = 0; i < _numOfQuestions; i++)            {                int qType = H.Helper.GetNumber("Enter Question Type (1: MCQ, 2: True/False): ", 1, 2);                if (qType == 1)                {                    _questions[i] = Q.MCQQuestion.CreateMCQQuestion();                }else if(qType == 2)                {                    _questions[i] = Q.TrueFalseQuestion.CreateTrueFalseQuestion();                }            }

            Exams.Add(new E.FinalExam(_numOfQuestions, _time, _questions));        }        else if (_examType == 2)        {            for (int i = 0; i < _numOfQuestions; i++)            {               _questions[i] = Q.MCQQuestion.CreateMCQQuestion();            }            
            Exams.Add(new E.PracticalExam(_numOfQuestions, _time, _questions));        }        else        {            Console.WriteLine("Invalid Exam Type");            return;        }        Console.Clear();        Console.WriteLine("Exam Created Successfully for Subject: " + Name);        Console.ReadKey();    }    public void StartExams()
    {
        int numOfExams = H.Helper.GetNumber("Enter Exam ID to start: ", 0, Exams.Count);
               if(Exams is not null && numOfExams >= 0 && numOfExams < Exams.Count)
        {
            Exams[numOfExams].ShowExam();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep((Exams[numOfExams].Time)*60);
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
           
            
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
               ts.Hours, ts.Minutes, ts.Seconds,
               ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
        else if (numOfExams < Exams.Count)
        {
            Console.WriteLine("No Exams by this id Available for Subject: {0}" , Name); Console.ReadKey();
        }
        else { Console.WriteLine("No Exams Avilaple for Subject {0}",Name);Console.ReadKey(); }
        Console.ReadKey();    }    public void PrintExams()        {        int numOfExams = H.Helper.GetNumber("Enter Exam ID to view details: ", 0, Exams.Count);

        if (Exams is not null && numOfExams >= 0 && numOfExams < Exams.Count)        {            Console.WriteLine("Exams for Subject: {0}" , Name);
            Console.WriteLine(Exams[numOfExams].ToString());
            Console.ReadKey();        }else if(numOfExams < Exams.Count)
        {
            Console.WriteLine("No Exams by this id Available for Subject: {0}" , Name); Console.ReadKey();
        }        else        {            Console.WriteLine("No Exams Available for Subject: {0}" , Name); Console.ReadKey();        }    }}