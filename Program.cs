using System;

namespace BBC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age =int.Parse (Console.ReadLine());
            Console.WriteLine("Ваша фамилия:" + surname);
            Console.WriteLine("Ваш возраст:" + age);
            Console.ReadLine();

        }
    }
}
