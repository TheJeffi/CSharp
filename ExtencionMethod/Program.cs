namespace ExtensionMethod
{
    public static class Extensions
    {
        public static int ExtendedAverage(this int[] num)
        {
            int average = 0;
            for (int i = 0; i < num.Length; i++)
            {
                average += num[i];
            }
            average /= num.Length;
            return average;
        }

        public static int ExtendedCharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }

        public static string ExtendedToString(this int num)
        {
            num += num;
            return num.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 442, 5 };

            string newNum = numbers[3].ExtendedToString();

            Console.WriteLine($"{numbers.ExtendedAverage()}, {newNum}, {newNum.ExtendedCharCount('8')}");
        }
    }
}