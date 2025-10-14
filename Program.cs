using System;

namespace Programflyt
{
    public class Program
    {
        public static int inputNumber;
        static void Main(string[] args)
        {
            Console.Write("Enter your mood, my dear employee. How would you rate your mood from 1 to 10? [input]:");
            while (true)
            {
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out inputNumber)) { Console.WriteLine("Well, decide"); continue; }
                if (inputNumber < 1 || inputNumber > 10) { Console.WriteLine("You must choose within the range!"); continue; }
                {
                    Sevises servis = new Sevises(inputNumber);
                    if (servis.InputNumber <= 0)
                    {
                        Console.WriteLine("You're scaring us, what happened?");
                        Thread.Sleep(5000);
                    }
                    else if (servis.InputNumber <= 5)
                    {
                        Console.WriteLine("It seems like you're not sure how you're feeling right now, so grab some apple pie from the lunch room.");
                        Thread.Sleep(5000);
                    }
                    else if (servis.InputNumber <= 10)
                    {
                        Console.WriteLine("Wow! You're in a good mood, here's some extra work for you!");
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        Console.WriteLine("Don't make things up, we told you to rate your mood on a scale of 1 to 10.");
                    }
                }
                GiftController.GiftClass.Gift();

                if (inputNumber >= 1 && inputNumber <= 10 && int.TryParse(input, out inputNumber))
                    break;
            }
        }
    }
}
