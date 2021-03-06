using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            User Andrew = new User(24, "Андрей");
            Andrew.GetInfo();

            User Vasya;
            Vasya.age = 25;
            Vasya.name = "Вася";
            Vasya.GetInfo();

            User Igor = new User();
            Igor.GetInfo();
        }
    }
    struct User
    {
        public int age;
        public string name;

        public void GetInfo()
        {
            Console.WriteLine($"age = {age}\nname = {name}");
        }

        public User(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
