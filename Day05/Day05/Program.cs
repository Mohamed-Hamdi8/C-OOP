using Day05.Q._1;
using Day05.Q._2;
using Day05.Q._3;
using System.Security.Principal;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1
            //Circle circle = new Circle();
            //circle.Reduis = 5;
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 10;
            //rectangle.Height = 10;
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Q.2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.Write("Enter username: ");
            //string username = Console.ReadLine();

            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();
            //if (username != null && password != null)
            //{
            //    if (authService.AuthenticateUser(username, password))
            //    {
            //        Console.WriteLine("User authenticated successfully!");

            //        Console.Write("Enter role to check authorization: ");
            //        Role role =(Role)Enum.Parse(typeof(Role),Console.ReadLine(),true);

            //        if(role != null)
            //        if (authService.AuthorizeUser(username, role))
            //            Console.WriteLine($"User authorized with role: {role}");
            //        else
            //            Console.WriteLine($"User not authorized for role: {role}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Authentication failed.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}
            #endregion

            #region Q.3
            //EmailNotificationService emailNotification = new EmailNotificationService();
            //emailNotification.SendNotification("Ahmedhamdi111@gmail.com", "How Are You");
            //SmsNotificationService smsNotification = new SmsNotificationService();
            //smsNotification.SendNotification("01024938686", "Your OTP code is 1234");
            //PushNotificationService pushNotification = new PushNotificationService();
            //pushNotification.SendNotification("User123", "You have a new notification");
            #endregion

        }
    }
}
