namespace Inventory_Management
{
    public class Store
    {
        private List<Item> items = new List<Item>();
        
        // Add method
        public void AddItem(Item item)
        {
            bool isItemExit = items.Any((i => i.Name == item.Name));
            if (isItemExit)
            {
                Console.WriteLine($"Item already exists. ");
                return ;
            }
            items.Add(item);
        }

        
        // Delete method
        public void DeleteItem(Item item)
        {
            Item isItemExist = items.FirstOrDefault((i => i.Name == item.Name));
            if (isItemExist != null)
            {
                items.Remove(isItemExist);
                Console.WriteLine("Item deleted successfully");
            }
            else
            {
                Console.WriteLine("Item not exist.");
            }
        }
        
        
        // GetCurrentVolume method
        public int GetCurrentVolume()
        {
            return items.Sum((i => i.Quantity));
        }

        // FindItemByName 
        public string FindItemByName(string itemName)
        {
            Item findItem = items.FirstOrDefault((i => i.Name == itemName));
            if (findItem != null)
            {
                return $"Item found: {findItem} ";
            }
            else
            {
                return $"Item not found ";
            }
        }

        // SortByNameAsc
        public List<Item> SortByNameAsc()
        {
            return items.OrderBy((i => i.Name)).ToList();
        }


        // Display a list
        public void DisplayStore()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}