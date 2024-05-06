namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintTo1000()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void CountBy3()
        {
            for (int i = 3; i <= 999; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void TwoNumsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are the same!");
            }

            else
            {
                Console.WriteLine($"{num1} and {num2} are NOT the same!");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is EVEN!");
            }

            else
            {
                Console.WriteLine($"{num1} is ODD!");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is POSITIVE!");
            }

            else
            {
                Console.WriteLine($"{num} is NEGATIVE!");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VoterAge(int myAge)
        {
            if (myAge >= 18)
            {
                Console.WriteLine($"You are old enough to vote!");
            }

            else
            {
                Console.WriteLine("You are not old enough to vote!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange(int number)
        {
            if (number is <= 10 && number >= -10)
            {
                Console.WriteLine($"{number} is in the range of -10 to 10.");
            }

            else
            {
                Console.WriteLine($"{number} is out of range.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Multiply1Thru12(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintTo1000();

            CountBy3();

            TwoNumsEqual(5, 7);

            EvenOrOdd(957);

            PosOrNeg(-93783674);

            VoterAge(16);

            InRange(-12);

            Multiply1Thru12(32);
        }
    }
}
