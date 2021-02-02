using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerMenager1 = new Customer();
            customerMenager1.customerName = "Maksut Emin";
            customerMenager1.customerSurname = "Kuzey";
            customerMenager1.customerNumber=0000001;
            customerMenager1.customerHometown = "Erzurum";
            customerMenager1.customerGender = "Erkek";

            Customer customerMenager2 = new Customer();
            customerMenager2.customerName = "Feyzanur";
            customerMenager2.customerSurname = "Kuzey";
            customerMenager2.customerNumber = 0000002;
            customerMenager2.customerHometown = "Erzurum";
            customerMenager2.customerGender = "Kadın";

            Customer customerMenager3 = new Customer();
            customerMenager3.customerName = "Furkan";
            customerMenager3.customerSurname = "Kuzey";
            customerMenager3.customerNumber = 0000003;
            customerMenager3.customerHometown = "Erzurum";
            customerMenager3.customerGender = "Erkek";

            Customer customerMenager4 = new Customer();
            customerMenager4.customerName = "Şevval";
            customerMenager4.customerSurname = "Kuzey";
            customerMenager4.customerNumber = 0000004;
            customerMenager4.customerHometown = "Erzurum";
            customerMenager4.customerGender = "Kadın";

            Customer[] customers = new Customer[] { customerMenager1, customerMenager2, customerMenager3, customerMenager4 };
            foreach (var customer in customers)
            {
                Console.WriteLine(string.Format("{0,-5} | {1,-15} | {2,-10}| {3,-10}| {4,-10}", customer.customerNumber,  customer.customerName , customer.customerSurname  , customer.customerGender  , customer.customerHometown));

            }
            


        }
    }
}
