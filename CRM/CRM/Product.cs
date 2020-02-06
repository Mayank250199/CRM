using System;
using System.Collections.Generic;
using System.Text;

namespace CRM
{

    class Product
    {
        int product_Id;
        string product_Name;
        string product_Category;
        int product_Total_Quantity;
        double product_Price;

        public void addProduct(int id, string name, string category, int tQty, double price)
        {
            product_Id = id;
            product_Name = name;
            product_Category = category;
            product_Total_Quantity = tQty;
            product_Price = price;
        }

         public int getproductId()
        {
            return product_Id;
        }

       public  double getproductPrice()
        {
            return product_Price;
        }

        public void Pdisplay()
        {
            Console.WriteLine("");
            Console.WriteLine("product_Id:"+product_Id);
            Console.WriteLine("product_Name:"+product_Name);
            Console.WriteLine("product_Category:"+product_Category);
            Console.WriteLine("product_Total_Quantity:"+product_Total_Quantity);
            Console.WriteLine("product_Price:"+product_Price);
            Console.WriteLine("");
        }
       
    }

}
