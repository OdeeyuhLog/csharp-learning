namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradingSystem gs = new();
            Console.WriteLine("Student Grading System");
            Console.WriteLine("----------------------");
            Console.Write("Enter grades (should be comma seperated): ");
            string input = Console.ReadLine();

            try
            {
                float gpaScore = gs.CalculateGpaScores(input);
                Console.WriteLine($"GPA Score: {gpaScore}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }




        }
    }
}
