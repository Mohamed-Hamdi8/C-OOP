using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Q._3
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[mohamedhamdi2882@gmail.com] Send To [{recipient}] : {message}"); 
        }
    }
}
