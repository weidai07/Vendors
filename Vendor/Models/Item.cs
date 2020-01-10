using System.Collections.Generic; 
namespace Vendor.Models
{
    public class Item 
    {
        private string description;
        public int Id;
        private static List<Item> list = new List<Item>{};

        public Item()
        {

        }
        public Item(string description)
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

        public static List<Item> getAllItems()
        {
            return list;
        }

        public static void clearAllItems()
        {
            list.Clear();
        }

        public string toString()
        {
            return "This item is "+this.description;
        }

        public static Item Find(int searchId)
        {
            return list[searchId-1];
        }
    }
}