using teachers_login_news.managers;

namespace teachers_login_news;
class Program
{
    static void Main(string[] args)
    {
        TeacherManager teacherManager = new();

        string command = "";

        do
        {
            Console.Write("enter the command:");
            command = Console.ReadLine();
            if (command.ToLower().Equals("add teacher"))
            {
                var teacher = new Teachers
                {   Id = 1,
                    Age=67,
                    Firstname="Ali",
                    lastname = "Mammadov",
                    EntryDate = DateTime.Now,
                    Profession = "Math",
                };
                teacherManager.Add(teacher);

            }
            else if (command.ToLower().Equals("print teacher"))
            {
                teacherManager.Print();
            }
     
        } while (command.ToLower() != "quit");

    }
}

