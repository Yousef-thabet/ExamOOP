using System;


namespace Exam_OOP.Helper
{
    public static class Helper
    {
        public static int GetNumber(string msg = "ENTER ID :", int min=1, int max=2)
        {
            int num;
            bool flag;
            do
            {
                Console.Write(msg);
                flag = int.TryParse(Console.ReadLine(), out num);
            }while(!flag || num<min || num>max );   
            return num;
        }
        public static double GetNumber(string msg = "ENTER Mark :")
        {
            double num;
            bool flag;
            do
            {
                Console.Write(msg);
                flag = double.TryParse(Console.ReadLine(), out num);
            } while (!flag || num < 0);
            return num;
        }
        public static string GetString(string msg = "ENTER Body :")
        {
            string text;
            do
            {
                Console.Write(msg);
                text = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(text));
            return text;
        }

    }
}
