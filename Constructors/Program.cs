using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(23);
            customerManager.List();
            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product { Id = 2, Name = "Computer" };

            EmployeManager employeManager = new EmployeManager();
            employeManager.Logger=new DatabaseLogger();
            employeManager.Add();

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count = 10;
        public CustomerManager(int count)
        {
           _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
     interface ILogger
    {
        void Log();
    }
   class DatabaseLogger:ILogger
    {
          public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
     class FileLogger:ILogger
    {
          public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeManager
    {

        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();   
            Console.WriteLine("Added!");
        }
        }
}
