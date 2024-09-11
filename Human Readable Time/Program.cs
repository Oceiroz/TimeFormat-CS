using System;

namespace Human_Readable_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetIntInput("input a number of seconds");
            FormatTime(value);
        }
        static int GetIntInput(string inputMessage)
        {
            int userInput = 0;
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                string rawInput = Console.ReadLine();
                try
                {
                    userInput = int.Parse(rawInput);
                    if (userInput < 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("this is not a valid input");
                }
            }
            return userInput;
        }
        static void FormatTime(int seconds)
        {
            int secondsLeft = seconds % 60;
            int minutes = seconds / 60;
            int minutesLeft = minutes % 60;
            int hours = minutes / 60;
            string strSeconds = secondsLeft.ToString("00");
            string strMinutes = minutesLeft.ToString("00");
            string strHours = hours.ToString("00");
            if (hours < 100)
            {
                Console.WriteLine($"{strHours}:{strMinutes}:{strSeconds}");
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
