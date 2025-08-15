
using S = Exam_OOP.Subject;
using H = Exam_OOP.Helper;
namespace Exam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region console set
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.Title = "Examiation System";
            Console.ForegroundColor = ConsoleColor.Yellow; 
            #endregion

            bool run = true;

            Console.WriteLine("============== Create New Subject =============");
            string NameOfSubject = H.Helper.GetString("Enter Subject Name: ");
            int NumberOfSubject = H.Helper.GetNumber("Enter Id Subject:", 1, 200);
            S.Subject subject = new S.Subject(NumberOfSubject, NameOfSubject);
            do
            {
                Console.Clear();
                int desion = H.Helper.GetNumber("ENTER NUMBER FOR\nCreate NEW Exam [1]:\nPrint Exams [2]:\nStart Exams [3]:\nEnd Program [4]:\n", 1, 4);
                switch (desion)
                {
                    case 1:
                        subject.CreateExam();
                        break;
                    case 2:
                        subject.PrintExams();
                        break;
                    case 3:
                        subject.StartExams();
                        break;
                    default:
                        Console.WriteLine("Thanks for Using :)");
                        run = false;
                        break;
                }
            } while (run);
        }
    }
}
