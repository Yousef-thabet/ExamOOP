using System;


namespace Exam_OOP.Helper
{
    public static class Helper
    {
        /// <summary>
        /// Prompts the user to enter a number within a specified range and validates the input.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid integer within the specified
        /// range is entered.</remarks>
        /// <param name="msg">The message to display to the user when prompting for input. Defaults to "ENTER ID :".</param>
        /// <param name="min">The minimum acceptable value for the input. Defaults to 1.</param>
        /// <param name="max">The maximum acceptable value for the input. Defaults to 2.</param>
        /// <returns>The validated number entered by the user, which will be within the range specified by <paramref name="min"/>
        /// and <paramref name="max"/>.</returns>
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
        /// <summary>
        /// Prompts the user to enter a non-negative number and validates the input.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid non-negative number is
        /// entered.</remarks>
        /// <param name="msg">The message to display to the user when prompting for input. Defaults to "ENTER Mark :".</param>
        /// <returns>A non-negative double value entered by the user.</returns>
        public static double GetNumber(string msg = "ENTER Mark :",double min =.5 , double max=10)
        {
            double num;
            bool flag;
            do
            {
                Console.Write(msg);
                flag = double.TryParse(Console.ReadLine(), out num);
            } while (!flag || num < min|| num>max);
            return num;
        }
        /// <summary>
        /// Reads a non-empty, non-whitespace string from the console after displaying a prompt message.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid input is provided.  It ensures
        /// that the returned string contains meaningful content.</remarks>
        /// <param name="msg">The message to display as a prompt before reading input. Defaults to "ENTER Body :".</param>
        /// <returns>A trimmed string entered by the user that is neither null, empty, nor consists solely of whitespace.</returns>
        public static string GetString(string msg = "ENTER Body :")
        {
            string text;

            do
            {
                Console.Write(msg);
                text = Console.ReadLine()?.Trim();
            } while (string.IsNullOrWhiteSpace(text));
            return text;
        }

    }
}
