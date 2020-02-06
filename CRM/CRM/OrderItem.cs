using System;
using System.Collections.Generic;
using System.Text;

namespace CRM
{
    class OrderItem 
    {
        public int orderItem_Id;
        public int product_Id;
        public int customer_Id;
        private int product_quantity;
        private double orderItem_TotalPrice;


      public  void addOrderItem(int id, int product_id, int customer_id, int product_Qty, double price)
        {
            orderItem_Id = id;
            product_Id = product_id;
            customer_Id = customer_id;
            product_quantity = product_Qty;
            orderItem_TotalPrice = product_Qty * price;

        }

        public int getOrderItemID()
        {
            return orderItem_Id;
        } 

      public  void displayOrderItem()
        {
            Console.WriteLine("");
            Console.WriteLine("Your order");
            Console.WriteLine("");
            Console.WriteLine("Order Item:" + orderItem_Id);
            Console.WriteLine("Product ID:"+product_Id);
            Console.WriteLine("Customer_ID:"+customer_Id);
            Console.WriteLine("Product Quantity:"+product_quantity);
            Console.WriteLine("Total Order Price:"+orderItem_TotalPrice);
            Console.WriteLine("");
        }
      
    }

}
