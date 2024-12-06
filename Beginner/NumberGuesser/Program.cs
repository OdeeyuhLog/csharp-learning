namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numberGuessed = false;
            int userInputNumber, randomGeneratedNumber;

            Random rand = new Random();

            randomGeneratedNumber = rand.Next(100);

            while (!numberGuessed)
            {
                Console.Write("Enter a number: ");
                userInputNumber = Int32.Parse(Console.ReadLine());

                if (userInputNumber == randomGeneratedNumber)
                {
                    numberGuessed = true;
                    Console.WriteLine("You guessed the random number!");
                }
                else
                {
                    if (userInputNumber < randomGeneratedNumber)
                    {
                        Console.WriteLine("Higher");
                    }

                    if (userInputNumber > randomGeneratedNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                }


            }
        }
    }
}
