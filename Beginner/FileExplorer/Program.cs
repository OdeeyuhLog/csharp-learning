namespace FileExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string backTrackedPath = Path.Combine(currentDirectory, "../../..");

            string fileDirectory = Path.GetFullPath(backTrackedPath);
            Console.WriteLine("File Directory: " + fileDirectory);

            while (true)
            {
                Console.WriteLine("File Explorer");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Read File");
                Console.WriteLine("2. Write File");
                Console.WriteLine("3. Quit Explorer");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of the file: ");
                        String fileName = Console.ReadLine() + ".txt";
                        String fileToFind = fileDirectory + "/" + fileName;
                        if (File.Exists(fileToFind) && ((Path.GetExtension(fileToFind) == ".txt")))
                        {
                            StreamReader streamReader = new StreamReader(fileToFind);
                            string line;

                            while ((line = streamReader.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The file that you want to read does not exist.");
                            Console.WriteLine("Or is not a .txt file.");
                        }
                        break;

                    case 2:
                        Console.Write("Enther the name of the file: ");
                        String newFileName = Console.ReadLine() + ".txt";
                        Console.Write("Enter the initial content of the file: ");
                        String newFileInitialContent = Console.ReadLine();

                        String newFilePath = fileDirectory + "/" + newFileName;

                        StreamWriter sw = new StreamWriter(newFilePath, true);
                        sw.WriteLine(newFileInitialContent);
                        sw.Close();

                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
