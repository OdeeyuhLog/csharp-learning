namespace StudentGradingSystem
{
    internal class GradingSystem
    {
        private static readonly Dictionary<(int Lower, int Upper), char> GradeRanges = new()
        {
            { (95, int.MaxValue), 'A' },
            { (88, 94), 'B' },
            { (85, 87), 'C' },
            { (80, 84), 'D' },
            { (75, 79), 'E' },
            { (70, 74), 'F' },
        };

        public float CalculateGpaScores(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                throw new ArgumentException("Input cannot be empty");
            }

            try
            {
                int[] grades = userInput.Split(',').Select(g => int.Parse(g.Trim())).ToArray();

                if (grades.Any(g => g < 0 || g > 100))
                    throw new ArgumentOutOfRangeException(nameof(userInput), "Grades must be between 0 and 100 ");

                return CalculateGpa(grades);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid input. Please provide comma-seperated values");
            }

        }

        private float CalculateGpa(int[] grades)
        {
            return grades.Select(GetLetterGrade).Select(GetGpaScore).Average();
        }

        private char GetLetterGrade(int grade)
        {
            return GradeRanges.FirstOrDefault(range => grade >= range.Key.Lower && grade <= range.Key.Upper).Value;
        }

        private float GetGpaScore(char letterGrade) => letterGrade switch
        {
            'A' => 4.0f,
            'B' => 3.5f,
            'C' => 3.0f,
            'D' => 2.5f,
            'E' => 2.0f,
            'F' => 1.5f,
            _ => 0.0f
        };


    }
}
