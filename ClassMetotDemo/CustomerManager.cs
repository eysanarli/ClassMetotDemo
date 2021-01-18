using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        private List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname +  "----------- Müşteri Ekleme İşlemi Başarılı!");
        }

        public void Listele() // This method is used for printing all customer in the list
        {
            Console.WriteLine("-------------------------------------------");
            foreach (var customer in customers)
            {
                Console.WriteLine("İsim- Soyisim = " + customer.Name + " " + customer.Surname + " " + "Doğum Yılı =" + customer.Birthyear + " " + "Bakiye = " + " " + customer.Balance + "Kredi Puanı =" + customer.CreditScore );
            }
            Console.WriteLine("-------------------------------------------");
        }
        public void Delete(Customer customer)
        {

            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.Birthyear + "----------- Müşteri Silme İşlemi Başarılı!");
        }

        public void CustomerEdit(Customer customer)
        {
            Console.WriteLine("DÜZENLEME");
            Console.WriteLine(" ");
            Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.Birthyear + " " + customer.CreditScore + " " + customer.Password);
            Console.WriteLine(" ");
            Console.WriteLine("Müşteri Güncellendi!");
            Console.WriteLine(" ");
        }
    }
}
