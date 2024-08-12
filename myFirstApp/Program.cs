using System;
using System.IO;
using System.Threading.Channels;
using myFirstApp.@class;


class Program
{
    
    static void Main(string[] args)
    {
        List<User> users = new List<User>
            {
                new User { Login = "skochik-2003@mail.ru", Name = "Eduard", IsPremium = false },
                new User { Login = "ivan@example.com", Name = "Ivan", IsPremium = true },
                new User { Login = "maria@example.com", Name = "Maria", IsPremium = false },
                // Можно добавить больше пользователей сюда
            };

        // Приветствие и показ рекламы для каждого пользователя

        foreach (var user in users)
        {
            user.Greet();
        }

        Console.ReadKey();
    }
}
