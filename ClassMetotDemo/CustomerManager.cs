using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(int num, Customer[] customers)
        {
            Customer customer = new Customer();

            customer.Num = num;

            Console.Write("Eklemek istediğiniz müşterinin T.C. kimlik nosunu giriniz : ");
            customer.Id = 5;

            Console.Write("Eklemek istediğiniz müşterinin adını giriniz:");
            customer.Name = Console.ReadLine();

            Console.Write("Eklemek istediğiniz müşterinin soyadını giriniz:");
            customer.Surname = Console.ReadLine();

            customers[num] = customer;



            Console.WriteLine(" \n --------Bilgieri girilen kişi müşteri listesine başarıyla eklenmiştir------- \n ");

        }

        public void Remove(Customer[] customers, CustomerManager customerManager)
        {
            int num;

            Console.WriteLine(" Silmek istediğiniz müşterinin sırasını giriniz: ");
            num = Convert.ToInt32(Console.ReadLine());
            customers[num].Id = 5;
            customers[num].Name = "";
            customers[num].Surname = "";

            customerManager.List(customers);
        }

        public void List(Customer[] customers)
        {
            Customer customer = new Customer();

            Console.WriteLine(" \n -----------Müşteri Listesi---------- \n ");

            foreach (Customer customer1 in customers)
            {
                Console.WriteLine("Müşteri sırası: " + customer.Num);
                Console.WriteLine("Müşteri T.C. no: " + customer.Id);
                Console.WriteLine("Müşterinin ismi: " + customer.Name);
                Console.WriteLine("Müşterinin soyismi: " + customer.Surname);

            }

            Console.WriteLine("\n --------İşlem sonu---------- \n");
        }

    }
}
