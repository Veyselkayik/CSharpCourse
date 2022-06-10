using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IntarfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
                {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Veysel",
                LastName = "Kayık",
                Adress = "İstanbul"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Ezgi",
                LastName = "Doğan",
                Departmant = "Computer Science"
            };
            manager.Add(customer);
            manager.Add(student);
            //manager.Add(new Customer { Id = 1, FirstName = "Veysel", LastName = "Kayık", Adress = "İstanbul" });
        }
    }

    interface IPerson
    {
        int Id { get; set; } //prop enter
        string FirstName { get; set; } //prop enter
        string LastName { get; set; } //prop enter
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}