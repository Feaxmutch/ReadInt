namespace ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parsedNumber = ReadInt();
            Console.WriteLine(parsedNumber);
        }

        private static int ReadInt()
        {
            string userInput = string.Empty;
            int result;

            while (int.TryParse(userInput, out result) == false)
            {
                Console.Clear();
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();
            }

            return result;
        }
    }
}
