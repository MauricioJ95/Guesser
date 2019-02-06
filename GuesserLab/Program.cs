using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesserLab
{
    class Program
    {
        static void Main(string[] args)
        {

            int computerNumer = GetNumber(0, 100);


            bool stillGuessing = true;
            string message = "Give me a number between 0 and 100";
            int count = 1;

            while (stillGuessing)
            {

                int userNumber = GetUserNumber(message, 0, 100);
                int difference = DoSubtraction(userNumber, computerNumer);

                if (difference == 0)
                {
                    message = "Congratulations! Yay! You did it!";
                }
                else
                {
                    count++;
                    if (difference > 0)
                    {

                        if (difference >= 10)
                        {
                            message = "Up on your HIGH horse ain't ya?";
                        }
                        else
                        {
                            message = "Too high.";
                        }
                    }
                    else
                    {

                        if (difference <= -10)
                        {
                            message = "Shawty got LOW-LOW-LOW-LOW-LOW-LOW-LOW-LOW";
                        }
                        else
                        {
                            message = "Too low";
                        }
                    }
                }
            }
            Console.WriteLine(message);
        }

        public static int DoSubtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int GetNumber(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        public static int GetUserNumber(string message, int min, int max)
        {
            int userNumber = min - 1;
            Console.WriteLine(message);

            if (userNumber < min || userNumber > max)
            {
                while (!int.TryParse(Console.ReadLine(), out userNumber)) ;
            }

            return userNumber;


        }
    }
}

