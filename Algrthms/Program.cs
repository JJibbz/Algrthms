namespace Algrthms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("login", "name", true);
            User user2 = new User("login1", "name1", false);
            User user3 = new User("login2", "name2", false);
            User user4 = new User("login3", "name3", true);
            User[] users = {user1, user2, user3, user4};

            foreach (User user in users)
            {
                Greetings(user.Name);
                if (user.IsPremium)
                {
                    ShowAds();
                }
            }

        }

        static void Greetings(string name)
        {
            Console.WriteLine($"Здравствуйте, {name}");

        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
