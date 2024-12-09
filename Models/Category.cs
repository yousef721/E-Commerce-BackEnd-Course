namespace E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Category> Categories { get;} = new List<Category>();
    }
}
