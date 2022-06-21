namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ListLearning();
        }

        private void ListLearning()
        {
            List<(string name, string text)> messages = new List<(string name, string text)>(3) {("Bob","Hello world"),("Tom", "Winter was cold"),("Sam", "My name is Sam") };

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.name}: {message.text}");
            }

            Console.WriteLine("Delete message from Sam");
            messages.RemoveAt(messages.Count -1);

            Console.WriteLine("New message from Anna");

            messages.Insert(messages.Count, ("Anna", "Hello how are you?"));

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.name}: {message.text}");
            }

            (int,(string name,string text))[] ID = new (int, (string name, string text))[4];

            for (int i = 0; i < messages.Count; i++)
            {
                ID[i].Item1 = i;
                ID[i].Item2 = messages[i];
            }

            foreach (var item in ID)
            {
                Console.WriteLine(item);
            }

        }
    }
}