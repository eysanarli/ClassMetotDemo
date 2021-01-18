using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(0,"Eyşan","Arlı",1994,1000,70,"Password : 1234");

            Customer customer2 = new Customer(1,"Onur","Yüksel",1992,50,10, "Password : 5678");

            Customer customer3 = new Customer(2,"Ebru","Köse",1994,2000,75, "Password : 9876");

            Customer customer4 = new Customer(3,"Enes","Yıldırım",1992,500,65, "Password : 5432");


            CustomerManager cm = new CustomerManager();
            Customer[] customers = { customer1,customer2,customer3,customer4};

            foreach (var customer in customers)
            {
                cm.Add(customer);
            }
            cm.Listele();

            foreach (var customer in customers)
            {
                cm.Delete(customer);
            }

            foreach (var customer in customers)
            {
                cm.CustomerEdit(customer);
            }
            

            Console.ReadLine();










        }
    }
}
