namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, menuChoice;
            bool onMenuFocus = true;

            while (onMenuFocus)
            {

                Console.WriteLine("Calculator System");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Quit Calculator");
                Console.Write("Enter menu choice number: ");

                menuChoice = Int32.Parse(Console.ReadLine());

                if (menuChoice == 5)
                {
                    onMenuFocus = false;
                }
                else
                {

                    displayOperation(menuChoice);
                }




            }
        }



        static void displayOperation(int choice)
        {
            int result;
            Console.WriteLine("Enter 1st number: ");
            int value1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int value2 = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = value1 + value2;
                    Console.WriteLine($" The sum of {value1} and {value2} is {result} ");
                    break;
                case 2:
                    result = value1 - value2;
                    Console.WriteLine($" The difference of {value1} and {value2} is {result} ");
                    break;
                case 3:
                    result = value1 * value2;
                    Console.WriteLine($" The product of {value1} and {value2} is {result} ");
                    break;
                case 4:
                    result = value1 / value2;
                    Console.WriteLine($" The quotient of {value1} and {value2} is {result} ");
                    break;
            }

        }
    }
}
