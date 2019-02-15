using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKB.BankClient.BLL.User;
using KKB.BankClient.BLL.User.Account;
using RandomUser;
using KKB.BankClient.Web.Model;
namespace KKB.BankClient.Web
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceMenu.MainMenu();
            //ServiceUser service = new ServiceUser();

            //User user = new User();

            
            //user.FirstName = "Евгений";
            //user.LastName = "Герцен";            
            //user.Login = "admin";
            //user.Password = "admin";

            //string message = "";
            //if (service.RegisterUser(user, out message))
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(message);
            //    Console.ForegroundColor = ConsoleColor.White;

            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(message);
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
        }
    }
}
