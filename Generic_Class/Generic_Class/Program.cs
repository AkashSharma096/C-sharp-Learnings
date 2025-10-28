using generics;

namespace generic_class
{
    class Program
    {
        static void Main()
        {
            User<string, int> user1 = new User<string, int> { userName = "Akash", userId = 1234 };
            User<string, bool> user2 = new User<string, bool> { userName = "Ramesh", userId = false };


            System.Console.WriteLine($"UserName:{user1.userName} and UserId : {user1.userId}");
            System.Console.WriteLine($"UserName:{user2.userName} and UserId : {user2.userId}");

        }
    }
}
