namespace overOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("pol");
            Thread.Sleep(10000);
            User user2 = new User("ron");

            Console.WriteLine(user1 + "\n" + user2); 
            Console.WriteLine(user1 < user2);
        }
    }
}