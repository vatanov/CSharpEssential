using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User("Vampire", "Vovann", "Vovanoff", 30);
            usr.ShowUserInfo();

            Console.ReadKey();
        }
    }
}
