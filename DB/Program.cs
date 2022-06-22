

namespace DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                User tom = new User { FirstName = "Tom", LastName = "Jackson", Birthday = DateTime.Parse("10.01.2021"), Gender = 'm' };
                User alice = new User { FirstName = "Alice", LastName = "Thompson", Birthday = DateTime.Parse("10.04.2008"), Gender = 'f' };

                db.Users.Add(tom);
                db.Users.Add(alice);
                User Jack = new User { FirstName = "Jack", LastName = "Jackson", Birthday = DateTime.Parse("10.01.2021"), Gender = 'm' };
                db.Users.Add(Jack);
                db.SaveChanges();
                Console.WriteLine("DB save");
                var users = db.Users.ToList();
                Console.WriteLine("Users:");
                foreach (User user in users)
                {
                    Console.WriteLine($"ID: {user.Id} Fullname:  {user.FirstName} {user.LastName} Birthday: {user.Birthday} Gender: {user.Gender}");
                }
            }
        }
    }
}