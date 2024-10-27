namespace Inventory_Management
{
    public class Item
    {
        // Feilds
        public string Name { get; } // readonly
        
        private int quantity;
        
        public int Quantity 
        {
            get { return quantity;}
            set { quantity = value;}   
        }
        private DateTime CreatedDate { get; set; }

        // Constructure
        public Item(string name, int quantity, DateTime? createdDate = null)
        {
            if (quantity < 0)
            {
                Console.WriteLine($"The quantity of item cannot be negative");
            }
            Name = name;
            Quantity = quantity;
            // If createdDate is null, set it to the current date and time
            CreatedDate = createdDate ?? DateTime.Now;
        }

        // To convert object to string
        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}, Date {CreatedDate}";
        }
    }
}