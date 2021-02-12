using System;

namespace CustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 15;
            customer1.Name = "Mehmet";
            customer1.SurName = "Orman";
            customer1.Phone = 123456788;
            customer1.Email = "abc@gmail.com";

            Customer customer2 = new Customer();
            customer2.Id = 16;
            customer2.Name = "Tahsin";
            customer2.SurName = "Dağ";
            customer2.Email = "123@gmail.com";
            customer2.Phone = 464891231;
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerInfo(customer1);
            customerManager.CustomerInfo(customer2);

           /*
            Customer[] customers = new[] {customer1,customer2};
            foreach (Customer customer in customers)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Id      : "+ customer.Id);
                Console.WriteLine("Name    : "+ customer.Name);
                Console.WriteLine("Surname : "+ customer.SurName);
                Console.WriteLine("Email   : "+ customer.Email);
                Console.WriteLine("Phone   : "+ customer.Phone);
            }
            */
        }
    }
}