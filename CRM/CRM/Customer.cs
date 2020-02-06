using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;


namespace CRM
{
   //static class customer
   // {
   //     public static Object customerList = new List<Object>();
   // }
    class Customer
    {
       public int customer_Id;
       private string customer_Name;
       private int customer_Age;
       private string customer_Address;
       private string customer_EmailId;
       private string customer_password;
       private long customer_PhoneNo;

        public void addCustomer(int id, string name, int age, string addr, string emailId, string passw, long phone)
        {
            customer_Id = id;
            customer_Name = name;
            customer_Age = age;
            customer_Address = addr;
            customer_EmailId = emailId;
            customer_password = passw;
            customer_PhoneNo = phone;
        }


       public int getCustomerId()
        {
            return customer_Id;
        }

        public string getCustomeremailId()
        {
            return customer_EmailId;
        }

        public string getCustomerPassword()
        {
            return customer_password;
        }
        public void Cdisplay()
        {
            Console.WriteLine("");
            Console.WriteLine("All Customer");
            Console.WriteLine("");
            Console.WriteLine("Customer ID:" + customer_Id);
            Console.WriteLine("Customer Name:" + customer_Name);
            Console.WriteLine("Customer Age:"+customer_Age);
            Console.WriteLine("Customer Address:"+customer_Address);
            Console.WriteLine("Customer EmailID:"+customer_EmailId);
            Console.WriteLine("Customer PhoneNo:"+customer_PhoneNo);
            Console.WriteLine("");
        }

    }

   

  
}
