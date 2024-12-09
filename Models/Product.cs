namespace E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }

        public Category CategoryID { get; set; }

        public Category Category { get; } = new Category();








    }
}
