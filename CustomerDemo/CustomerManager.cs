using System;

namespace CustomerDemo
{
    public class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine($"{customer.Name} Isimli Musteri Eklendi.");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} Isimli Musteri Silindi.");
        }

        public void CustomerInfo(Customer customer)
        {
            Console.WriteLine("Customer Info --- ");
            Console.WriteLine($"Id      : {customer.Id}");
            Console.WriteLine($"Name    : {customer.Name}");
            Console.WriteLine($"Surname : {customer.SurName}");
            Console.WriteLine($"Email   : {customer.Email}");
            Console.WriteLine($"Phone   : {customer.Phone}");
        }
        
    }
}