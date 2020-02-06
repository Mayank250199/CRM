using System;
using System.Collections.Generic;

namespace CRM
{  
    class Program
    {
       static Product addPro(int id, string name, string category, int tQty, double price)
        {
            Product p = new Product();
            p.addProduct(id, name, category, tQty, price);

            return p;
        }

        static Customer addCus(int id, string name, int age, string addr, string emailId, string passw, long phone)
        {
            Customer c = new Customer();
            c.addCustomer(id, name, age, addr, emailId, passw, phone);

            return c;
        }


        static void Main(string[] args)
        {
            var customerList = new List<Customer>();
            var productList = new List<Product>();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                ******************* Customer Management System ******************                  ");


            //  ************ Customer List **************
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            c1.addCustomer(101, "Mayank", 14, "Korea", "mayank@gmail.com", "mayank", 9971246300);
            c2.addCustomer(102, "Rahul", 14, "Japan", "mayank1@gmail.com", "mayank1", 9971246300);

            customerList.Add(c1);
            customerList.Add(c2);

            foreach (var customer in customerList)
            {
                customer.Cdisplay();
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter Your Email ID");
            string emailid = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();


            foreach (var customer in customerList)
            {
                if (emailid.Equals(customer.getCustomeremailId()) && password.Equals(customer.getCustomerPassword()))
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                ******************* Customer Management System ******************                  ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Login Successful");


                    //  *************** Product List ****************
                    Product p1 = new Product();
                    Product p2 = new Product();
                    p1.addProduct(501, "Naruto Manga", "Anime", 101, 1000.50);
                    p2.addProduct(502, "Erased Manga", "Anime", 102, 1001.50);

                    productList.Add(p1);
                    productList.Add(p2);

                    foreach (var product in productList)
                    {
                        product.Pdisplay();
                    }


                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter Product ID:");
                    int productid = Convert.ToInt32(Console.ReadLine());

                    foreach (var product in productList)
                    {
                        if(productid == product.getproductId())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Enter Product Qty.");
                            int productQty = Convert.ToInt32(Console.ReadLine());
                            OrderItem o = new OrderItem();
                            o.addOrderItem(101, productid, customer.getCustomerId(), productQty, product.getproductPrice());
                            Console.Clear();

                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("                ******************* Customer Management System ******************                  ");
                            o.displayOrderItem();

                        }
                    }

                }
                else
                {
                    Console.WriteLine("No User Exit:");
                }

            }
            Console.ReadKey();
        }
    }
}
