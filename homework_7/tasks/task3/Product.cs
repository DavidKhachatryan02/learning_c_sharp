namespace Product_Task_3
{
    public class Product
    {
        public string Name;
        public string? Description;

        // NOTE! we can add defult value "no description available" Directly
        public Product(string name, string? description = null)
        {
            Name = name;
            Description = description;
        }
    }
}