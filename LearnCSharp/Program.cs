namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4523;
            int[] array = { 1, 3, 5, 6, 3 };
            int result = RecursiveGetSumElementsNumber(a);
            Console.WriteLine(result);
            RecursiveGetArraySumElem(array);
            RecursivePrintArray(array);
        }

        static int RecursiveGetSumElementsNumber(int number)
        {
            if (number < 10)
            {
                return number;
            }
            int lastDigit = number % 10;
            int nextDigit = number / 10;
            return lastDigit + RecursiveGetSumElementsNumber(nextDigit);
        }

        static void RecursivePrintArray(int[] array, int i = 0)
        {

            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                RecursivePrintArray(array, i + 1);
            }

        }

        static void RecursiveGetArraySumElem(int[] array, int i = 0, int sum = 0)
        {

            if (i < array.Length)
            {
                sum += array[i];
                RecursiveGetArraySumElem(array, i + 1, sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }

    }
}