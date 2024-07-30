using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ECommerceServiceLibrary;

namespace ECommerceServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ECommerceService)))
            {
                host.Open();
                Console.WriteLine("Usługa ECommerceService jest uruchomiona...");
                Console.WriteLine("Naciśnij [Enter], aby zatrzymać usługę.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
