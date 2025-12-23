using System;
using System.Collections.Generic;
using System.Text;
using Task12_1_5.Classes;

namespace Task12_1_5.Utilities
{
    internal class Utilities
    {

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        public static void GretingUsers(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Приветствуем Вас, " + users[i].Name);

                if (users[i].IsPremium != true)
                {
                    Utilities.ShowAds();
                }
            }
        }
    }
}
