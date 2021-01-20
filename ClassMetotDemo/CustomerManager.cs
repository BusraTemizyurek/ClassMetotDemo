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
            customer.Id = Console.ReadLine();

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
            customers[num].Id = "";
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
                Console.WriteLine("Müşteri sırası: " + customer1.Num);
                Console.WriteLine("Müşteri T.C. no: " + customer1.Id);
                Console.WriteLine("Müşterinin ismi: " + customer1.Name);
                Console.WriteLine("Müşterinin soyismi: " + customer1.Surname);

            }

            Console.WriteLine("\n --------İşlem sonu---------- \n");
        }

    }
}
