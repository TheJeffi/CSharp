using Microsoft.Data.Sqlite;

namespace DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.AddPersons();

            program.RemovePerson();

            program.PrintPersons();

            program.DeleteFromDB();

            program.PrintPersons();
        }

        private void AddPersons()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                ConsoleKey consoleKey = ConsoleKey.Y;
                while (consoleKey == ConsoleKey.Y)
                {
                    User user = new User();

                    Console.WriteLine("Write name");
                    user.FirstName = Console.ReadLine();

                    Console.WriteLine("Write lastname");
                    user.LastName = Console.ReadLine();

                    Console.WriteLine("Write Birthday (dd.mm.yyyy)");
                    user.Birthday = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Write gender (m/f)");
                    user.Gender = char.Parse(Console.ReadLine());

                    db.Users.Add(user);
                    db.SaveChanges();

                    Console.WriteLine("Add new person? Y - yes, any button - no");
                    consoleKey = Console.ReadKey(true).Key;
                }

            }
        }
        private void DeleteFromDB()
        {
            Console.WriteLine("Enter the name of the person you want to delete");
            string name = Console.ReadLine();

            string sqlExpression = $"DELETE From Users WHERE FirstName = '{name}'";
            using (var connection = new SqliteConnection("Data Source=persons.db"))
            {
                connection.Open();

                try
                {
                    SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();

                    Console.WriteLine($"Deleted objects: {number}");
                }
                catch (Exception)
                {

                    throw new Exception("Error when working with SQLite");
                }
            }
        }

        private void RemovePerson()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine("select id to delete");

                int id = int.Parse(Console.ReadLine());

                string sqlExpression = $"DELETE FROM Users WHERE id={id}";
                using (var connection = new SqliteConnection("Data Source=persons.db"))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                    int number = command.ExecuteNonQuery();

                    Console.WriteLine($"Deleted objects: {number}");
                }
            }
        }

        private void PrintPersons()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();

                foreach (User user in users)
                {
                    Console.WriteLine($"ID: {user.Id} Fullname:  {user.FirstName} {user.LastName} Birthday: {user.Birthday} Gender: {user.Gender}");
                }
            }
        }
    }
}