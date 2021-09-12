using System;

namespace secondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hi," + username);

            ////---------------------------------------------------

            Console.WriteLine("How old are you?");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);
            int nextYearAge = age + 1;
            Console.WriteLine("So, Next year you will be " + nextYearAge);

            ////////---------------------------------------------------


            Console.WriteLine("Hey lets play a little game. Please, give me one number");
            string userNumber1 = Console.ReadLine();
            Console.WriteLine("Now give me different one, I will show you which is bigger");
            string userNumber2 = Console.ReadLine();
            int maxNumber1 = int.Parse(userNumber1);
            int maxNumber2 = int.Parse(userNumber2);

            int maxResult = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine(maxResult + " " + "This number is the bigger one");






            ////-------------------------------------------------------------


            Console.WriteLine("And again give me please one number");
            string userNumber3 = Console.ReadLine();
            Console.WriteLine("Now can you give me another, I will show you which is smaller");
            string userNumber4 = Console.ReadLine();
            int minNumber3 = int.Parse(userNumber3);
            int minNumber4 = int.Parse(userNumber4);
            int minResult = Math.Min(minNumber3, minNumber4);
            Console.WriteLine(minResult + " " + "This number is the smallest");



            ////----------------------------------------------------------------------


            Console.WriteLine("One more time, can you give me some random number?");
            string userRandom1 = Console.ReadLine();
            Console.WriteLine("And another one, I will show you how much it can divide");
            string userRandom2 = Console.ReadLine();
            int random1 = int.Parse(userRandom1);
            int random2 = int.Parse(userRandom2);
            int divisionResult = random1 % random2;
            Console.WriteLine(divisionResult);
            Console.WriteLine("This is the result of dividing, this number is the one which is left over.");






            //------------------------------------------------------------------------

            Console.WriteLine("So lets continue to play, can you give me again random number? And I will show you is it even or odd");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("This one is even number");
            else
                Console.WriteLine("This one is odd number");

            ////-------------------------------------------------------------------

            Console.WriteLine("So next, lets do some MATH, we have a rectangle, so give me the lenght");
            string rectangle = Console.ReadLine();
            Console.WriteLine("And now i need the width of it");
            string rectangle2 = Console.ReadLine();
            int rectangle3 = int.Parse(rectangle);
            int rectangle4 = int.Parse(rectangle2);
            int multiply = rectangle3 * rectangle4;
            double numberToRound = multiply;
            double rounded = Math.Round(numberToRound, 2);


            Console.WriteLine(rounded);
            Console.WriteLine("So, we just got the area of rectangle");

            //---------------------------------------------------------------

            Console.WriteLine("Next step is for us to get the area of triangle whos both sides ar the same");
            Console.WriteLine("So can you give me the height of it");
            string triangle = Console.ReadLine();
            Console.WriteLine("And now I need the base line against which is the height");
            string triangle2 = Console.ReadLine();
            int triangle3 = int.Parse(triangle);
            int triangle4 = int.Parse(triangle2);
            int result = triangle3 * triangle4 / 2;
            Console.WriteLine(result);
            Console.WriteLine("And now we got the area of triangle");

            //---------------------------------------------------------

            Console.WriteLine("So Hi again, tell me please your name");
            string name = Console.ReadLine();
            Console.WriteLine("And how old are you?");
            string old = Console.ReadLine();
            Console.WriteLine("Hi," + name + ", " + "So your age is," + old);

            //--------------------------------------------------------

































        }
    }
}
