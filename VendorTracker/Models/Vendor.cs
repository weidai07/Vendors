using System.Collections.Generic; 

namespace VendorTracker.Models
{
    public class Vendor
    { 
        private static List<Vendor> vendorList = new List<Vendor>{};
        private List<Order> orderList;    
        private string name;

        public int Id;
        public Vendor()
        {
 
        }

        public Vendor(string name)
        {
            this.name = name;
            this.orderList = new List<Order>{};
            vendorList.Add(this);
            Id = vendorList.Count;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string new_name)
        {
            this.name = new_name;
        }

        public List<Order> getOrders()
        {
            return this.orderList; 
        }

        public void addOrder(Order new_order)
        {
            this.orderList.Add(new_order);
        }

        public static List<Vendor> getAllVendors()
        {
            return vendorList;
        }
        public static void deleteAllVendors()
        {
            vendorList.Clear();
        }

        public static Vendor findVendorById(int given_id)
        {
            return vendorList[given_id-1];
        }

        public string toString()
        {
            string result = "Vendor name " + this.name;
            return result;
        }
    }
}