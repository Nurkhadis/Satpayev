using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbayev.BLL;
using Satbayev.DAL;

namespace Satpayev.ConsoleApp
{
    internal class Program
    {
        public static string Path = "";
       
        static void Main(string[] args)
        {
            Console.Write("Введите путь к базе данных: ");
            Path = Console.ReadLine();

            ServiceClient service = new ServiceClient(Path);
            Client client = new Client();
            client.Iin = "306020500693";
            client.Email = "nurkhadissandibek@gmail.com";
            client.FirstName = "Nurkhadis";
            client.MiddleName = "Rustembekuly";
            client.LastName = "Sandibek";
            client.BirthDate = new DateTime(2003, 06, 12);
            /*client.CreateDate = new DateTime.Now;*/
            client.Address = new Address()
            {
                Country = "Kazakhstan",
                City = "Shymkent",
                Region = "Turkestan",
                PostalCode = "160000",
                Street = "Monke bi",
                House = "43"
            };
            service.Registration(client);
        }
    }
}
