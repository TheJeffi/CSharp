namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Tom", "Bob", "Sam" };

            (int id, string name)[] users = new (int, string)[3];
            for (int i = 0; i < names.Length; i++)
            {
                users[i] = (i, names[i]);
            }

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"ID: {users[i].id}, Name: {users[i].name}");
            }

            var someTuple = (1, "Lorem");

            GetValue(someTuple);
        }

        public static void GetValue((int Item1, string Item2) tuple)
        {
            Console.WriteLine($"Tuple first item = {tuple.Item1} type: {tuple.Item1.GetType()}, second item = {tuple.Item2}, type {tuple.Item2.GetType()}");
        }
    }
}

