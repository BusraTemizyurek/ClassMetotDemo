using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[2];

            int i = 0;
            while (i < customers.Length)
            {
                Console.WriteLine((i + 1) + ". Müşterinin bilgilerini giriniz");
                customerManager.Add(num, customers);
                num++;
                i++;
            }


            customerManager.List(customers);

            customerManager.Remove(customers, customerManager);



        }
    }
}
