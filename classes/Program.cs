using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //Customer customer = new Customer();
            //customer.Id = 2123;
            //customer.FirstName = "Ezgi";
            //customer.LastName = "Doğan";
            //customer.City = "Kırklareli Çingenesi";

            Customer customer = new Customer
            {
                Id = 2123,
                FirstName = "Ezgi",
                LastName = "Doğan",
                City = "Kırklareli Çingenesi"
            };

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.City);


            Humans veysel = new Humans();
            veysel.Add();

            Console.ReadLine();

            
        }
    }
  

    
    class Humans
    {
        public void Add()
        {
            Console.WriteLine("Veysel Kayık");

        }
    }
}
