using System.Collections.Generic; 
namespace Vendor.Models
{
    public class Order 
    {
        private string description;
        public int Id;
        private static List<Order> list = new List<Order>{};

        public Order()
        {

        }
        public Order(string description)
        {
            this.description = description;
            list.Add(this);
            Id = list.Count;
            
        }
        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string new_des)
        {
            this.description = new_des;
        }

        public static List<Order> getAllOrders()
        {
            return list;
        }

        public static void clearAllOrders()
        {
            list.Clear();
        }

        public string toString()
        {
            return "This order is "+this.description;
        }

        public static Order Find(int searchId)
        {
            return list[searchId-1];
        }
    }
}