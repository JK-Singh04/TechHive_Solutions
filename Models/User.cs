namespace TechHive_Solutions.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; } // 'required' ensures this property must be initialized
        public required string Email { get; set; } // 'required' ensures this property must be initialized
    }
}
