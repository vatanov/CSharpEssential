using System;

namespace Lesson02
{
    class User
    {
        #region Fields

        string login;
        string name;
        string familyName;
        int age;
        readonly DateTime date;

        #endregion

        #region Constructors

        public User(string login, string name, string familyName, int age)
        {
            this.login = login;
            this.name = name;
            this.familyName = familyName;
            this.age = age;
            this.date = DateTime.Now;
        }

        #endregion

        public void ShowUserInfo()
        {
            Console.WriteLine("User info:");
            Console.WriteLine("Login:\t\t" + this.login);
            Console.WriteLine("Name:\t\t" + this.name);
            Console.WriteLine("Surname:\t" + this.familyName);
            Console.WriteLine("Age:\t\t" + this.age);
            Console.WriteLine("Registered:\t" + this.date);
        }
    }
}
