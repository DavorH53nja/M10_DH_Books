namespace Books.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string FullName => $"{Name} {LastName}";
    }
}